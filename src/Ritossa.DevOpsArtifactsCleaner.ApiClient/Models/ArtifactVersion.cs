using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;

public class ArtifactVersion
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty("normalizedVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string NormalizedVersion { get; set; }

    [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
    public string Version { get; set; }

    [JsonProperty("isLatest", NullValueHandling = NullValueHandling.Ignore)]
    public bool IsLatest { get; set; }

    [JsonProperty("isListed", NullValueHandling = NullValueHandling.Ignore)]
    public bool IsListed { get; set; }

    public bool IsPreRelease => Version.Contains("-");

    [JsonProperty("storageId", NullValueHandling = NullValueHandling.Ignore)]
    public string StorageId { get; set; }

    [JsonProperty("views", NullValueHandling = NullValueHandling.Ignore)]
    public List<View> Views { get; set; }

    [JsonProperty("publishDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime PublishDate { get; set; }

    [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
    public string Href { get; set; }
}