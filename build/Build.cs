using System.Collections.Generic;
using Components;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;

[GitHubActions(
    "Nuke Build", 
    GitHubActionsImage.UbuntuLatest,
    On = [GitHubActionsTrigger.PullRequest],
    PublishArtifacts = true,
    InvokedTargets = [nameof(Build)],
    FetchDepth = 0)]
[GitHubActions(
    "Nuke Deploy",
    GitHubActionsImage.UbuntuLatest,
    OnPushBranches = ["master"],
    InvokedTargets = [nameof(Build), nameof(Deploy)],
    PublishArtifacts = true,
    ImportSecrets = ["DOCR_EU_DEV_PASSWORD", "DOCR_EU_DEV_USERNAME", "KUBECONFIG_CLUSTER"],
    FetchDepth = 0
)]
class Build : xBuild,
    //IAnalyzeSolution,
    IRunTests,
    IPublishContainerImages,
    IDeployClusterInfra,
    IDeployKubernetesManifests
{
    public static int Main() => Execute<Build>(x => x.Build);
    
    //TODO: Use private container registry
    string IPublishContainerImages.ContainerRegistryHost => "docker.io";
    string IPublishContainerImages.ContainerRegistry => "kslingerland";
    
    AbsolutePath IDeployKubernetesManifests.KubernetesManifestDirectory => RootDirectory / "src" / "k8s";
    
    string IDeployClusterInfra.ServerClusterContext => "groep1";
    
    IEnumerable<HelmChart> IDeployClusterInfra.HelmCharts =>
    [
        new("argo", "argo/argo-cd","7.6.9", "argo-cd", "argocd","https://argoproj.github.io/argo-helm", true, null),
        new("zabbix", "zabbix-community/zabbix", "5.0.2", "zabbix", "zabbix", "https://zabbix-community.github.io/helm-zabbix/", true, null)
    ];
}
