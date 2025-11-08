namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class GetAllPackagesParams : BaseParams
{
    /// <summary>
    /// One of the supported artifact package types.
    /// </summary>
    public required string ProtocolType { get; set; }

    /// <summary>
    /// True to return all versions of the package in the response. Default is false (latest version only).
    /// </summary>
    public bool IncludeAllVersions { get; set; }

    /// <summary>
    /// [OPTIONAL] Get the top N packages (or package versions where getTopPackageVersions=true)
    /// </summary>
    public int? Top { get; set; } = null;
    
    /// <summary>
    /// [OPTIONAL] Skip the first N packages (or package versions where getTopPackageVersions=true)
    /// </summary>
    public int? Skip { get; set; } = null;
}