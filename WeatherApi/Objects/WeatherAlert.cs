using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WeatherApi.Objects.SubObjects;

namespace WeatherApi.Objects;

public class WeatherAlert
{
    [JsonProperty("@context")]
    public List<object> Context { get; set; }

    [JsonProperty("features")]
    public List<Alerts> Alerts { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("updated")]
    public DateTime UpdatedTime { get; set; }
}
