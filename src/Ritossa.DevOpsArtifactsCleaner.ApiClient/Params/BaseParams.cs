using System.Security;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class BaseParams
{
    /// <summary>
    /// The name of the Azure DevOps organization.
    /// </summary>
    public required string Organization { get; set; }

    /// <summary>
    /// Project ID or project name.
    /// </summary>
    public string? Project { get; set; }

    /// <summary>
    /// Name or Id of the feed.
    /// </summary>
    public required string FeedId { get; set; }

    public required SecureString Pat { get; set; }
}