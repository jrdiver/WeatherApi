using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class Alerts
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("geometry")]
    public object Geometry { get; set; }

    [JsonProperty("properties")]
    public Properties Properties { get; set; }
}