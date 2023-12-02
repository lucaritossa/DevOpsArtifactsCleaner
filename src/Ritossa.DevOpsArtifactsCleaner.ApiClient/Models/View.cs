using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class View
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public object Url { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }
}