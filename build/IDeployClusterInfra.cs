using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Components;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tools.Helm;
using Nuke.Common.Tools.Kubernetes;
using Nuke.Common.Utilities.Collections;
using Serilog;

public interface IDeployClusterInfra : IGitRepository, IArtifacts, IVersion
{
    AbsolutePath HelmChartDirectory => RootDirectory / "src" / "k8s" / "charts";
    
    AbsolutePath HelmValuesDirectory => HelmChartDirectory / "values";
    
    string LocalClusterContext => "docker-desktop";
    
    string ServerClusterContext => "server-cluster";

    IEnumerable<HelmChart> HelmCharts => new List<HelmChart>();
    
    Target ClusterAuthentication => _ => _
        .TryTriggeredBy<xBuild>(x => x.Deploy)
        .OnlyWhenStatic(() => IsLocalBuild || Repository.IsOnMasterBranch())
        .TryAfter<IPublishContainerImages>(x => x.PublishContainerImages)
        .Executes(() =>
        {
            var kubeConfigCluster = Environment.GetEnvironmentVariable("KUBECONFIG_CLUSTER");
            var tempKubeConfigPath = Path.Combine(Path.GetTempPath(), "kubeconfig");
            var contextName = IsLocalBuild ? LocalClusterContext : ServerClusterContext;
            
            if (string.IsNullOrEmpty(kubeConfigCluster))
            {
                if (IsLocalBuild)
                {
                    kubeConfigCluster = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".kube", "config"));
                }
                else
                {
                    throw new Exception("KUBECONFIG_CLUSTER environment variable must be set.");
                }
            }

            if (!IsLocalBuild)
                Environment.SetEnvironmentVariable("KUBECONFIG", tempKubeConfigPath);
            
            File.WriteAllText(tempKubeConfigPath, kubeConfigCluster);
            File.SetAttributes(tempKubeConfigPath, FileAttributes.Normal);
            
            KubernetesTasks.Kubernetes($"config use-context {contextName} --kubeconfig {tempKubeConfigPath}");
            KubernetesTasks.KubernetesClusterInfo();
        });
    
    Target DeployHelmCharts => _ => _
        .DependsOn(ClusterAuthentication)
        .OnlyWhenStatic(() => IsLocalBuild || Repository.IsOnMasterBranch())
        .TryTriggeredBy<xBuild>(x => x.Deploy)
        .Executes(() =>
        {
            HelmTasks.Helm($"version --client");
            
            HelmCharts.ForEach(x =>
            {
                HelmTasks.HelmRepoAdd(_ => _
                    .SetName(x.Name)
                    .SetUrl(x.Repository));
                
                HelmTasks.HelmUpgrade(s => s
                    .SetRelease(x.Release)
                    .SetChart(x.Chart)
                    .SetVersion(x.Version)
                    .SetNamespace(x.Namespace)
                    .SetCreateNamespace(x.CreateNamespace)
                    .SetValues(HelmValuesDirectory / x.ValuesFile)
                    .EnableInstall()
                    .SetWait(true)
                );
            });
            
            if (IsLocalBuild)
            {
                // Retrieve and print the initial admin secret
                var secret = KubernetesTasks.Kubernetes($"get secret -n argocd argocd-initial-admin-secret -o jsonpath=\"{{.data.password}}\"")
                    .FirstOrDefault()
                    .Text;
                
                var decodedSecret = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(secret));

                Log.Information($"Argo CD initial admin password: {decodedSecret}");

                HelmCharts.ForEach(x =>
                {
                    HelmTasks.HelmUpgrade(s => s
                        .SetRelease(x.Release)
                        .SetChart(x.Chart)
                        .SetNamespace(x.Namespace)
                        .SetValues(RootDirectory / "src" / "environments" / x.ValuesFile));
                });
            }
        });
}
