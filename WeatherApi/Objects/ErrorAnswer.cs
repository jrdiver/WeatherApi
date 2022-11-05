using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherApi.Objects.SubObjects;

namespace WeatherApi.Objects;

internal class ErrorAnswer
{
    [JsonProperty("correlationId")]
    public string CorrelationId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("detail")]
    public string Detail { get; set; }

    [JsonProperty("instance")]
    public string Instance { get; set; }

    [JsonProperty("parameterErrors")]
    public List<ParameterError> ParameterErrors { get; set; }
}

