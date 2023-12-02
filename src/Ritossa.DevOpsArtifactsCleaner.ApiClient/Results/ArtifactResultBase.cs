using Newtonsoft.Json;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient.Results;

public abstract class ResultBase<T>
{
    [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
    public int Count { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public List<T> Value { get; set; }
}