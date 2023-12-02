namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class GetAllPackagesParams : BaseParams
{
    public string ProtocolType { get; set; }
    public bool IncludeAllVersions { get; set; }
}