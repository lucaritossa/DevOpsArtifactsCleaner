using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class ArtifactPackage
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("normalizedName", NullValueHandling = NullValueHandling.Ignore)]
    public string NormalizedName { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("protocolType", NullValueHandling = NullValueHandling.Ignore)]
    public string ProtocolType { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public string Url { get; set; }

    [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
    public List<ArtifactVersion> Versions { get; set; }

    [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
    public Links Links { get; set; }
}