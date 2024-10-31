using Components;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.Kubernetes;

public interface IDeployKubernetesManifests : IGitRepository
{
    AbsolutePath KubernetesManifestDirectory => RootDirectory / "src" / "k8s";
    
    Target DeployManifests => _ => _
        .TryTriggeredBy<xBuild>(x => x.Deploy)
        .TryAfter<IDeployClusterInfra>(x => x.DeployHelmCharts)
        .OnlyWhenStatic(() => IsLocalBuild || Repository.IsOnMasterBranch())
        .Executes(() =>
        {
            KubernetesTasks.KubernetesApply(s => s
                .SetFilename(KubernetesManifestDirectory));
        });
    
}
