using System.Security;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;

public class BaseParams
{
    public string Organization { get; set; }
    public string Project { get; set; }
    public string FeedId { get; set; }
    public SecureString Pat { get; set; }
}