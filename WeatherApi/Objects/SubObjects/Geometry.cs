using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class Geometry
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("coordinates")]
    public List<double> Coordinates { get; set; }
}