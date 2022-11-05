using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

internal class ParameterError
{
    [JsonProperty("parameter")]
    public string Parameter { get; set; }
        
    [JsonProperty("message")]
    public string Message { get; set; }
}