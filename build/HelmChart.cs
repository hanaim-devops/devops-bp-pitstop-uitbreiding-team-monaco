using JetBrains.Annotations;

public class HelmChart
{
    public string Name { get; set; }
    
    public string Chart { get; set; }
    
    public string Version { get; set; }
    
    public string Release { get; set; }
    
    public string Namespace { get; set; }
    
    public string Repository { get; set; }
    
    public bool CreateNamespace { get; set; }
    
    public string ValuesFile { get; set; }

    public HelmChart(string name, string chart, string version, string release, string @namespace, string repository, bool createNamespace, [CanBeNull] string valuesFile = null)
    {
        Name = name;
        Chart = chart;
        Version = version;
        Release = release;
        Namespace = @namespace;
        Repository = repository;
        CreateNamespace = createNamespace;
        ValuesFile = $"values-{Release}.yaml";
    }
}
