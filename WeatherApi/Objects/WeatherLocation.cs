using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherApi.Objects.SubObjects;

namespace WeatherApi.Objects;

public class WeatherLocation
{
    [JsonProperty("@context")]
    public List<object> Context { get; set; }

    [JsonProperty("id")]
    public string PointsLink { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("geometry")]
    public Geometry Geometry { get; set; }

    [JsonProperty("properties")]
    public ForecastLinks Properties { get; set; }

    public double Latitude;
    public double Longitude;
}