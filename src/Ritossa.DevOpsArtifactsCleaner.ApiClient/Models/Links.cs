using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class Links
{
    [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
    public SelfLink Self { get; set; }

    [JsonProperty("feed", NullValueHandling = NullValueHandling.Ignore)]
    public FeedLink Feed { get; set; }

    [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
    public VersionsLink Versions { get; set; }
}