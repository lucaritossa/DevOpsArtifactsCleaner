namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class DeleteNugetPackageVersionParams : BaseParams
{
    public class Package
    {
        public string IdOrName { get; set; }
        public string Version { get; set; }
    }

    public List<Package> Packages { get; set; } = new();
}