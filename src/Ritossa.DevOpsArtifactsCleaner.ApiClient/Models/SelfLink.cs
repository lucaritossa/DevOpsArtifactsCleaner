using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class SelfLink
{
    [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
    public string Href { get; set; }
}