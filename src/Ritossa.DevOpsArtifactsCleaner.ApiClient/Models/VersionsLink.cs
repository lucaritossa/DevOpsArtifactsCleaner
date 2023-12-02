using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class VersionsLink
{
    [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
    public string Href { get; set; }
}