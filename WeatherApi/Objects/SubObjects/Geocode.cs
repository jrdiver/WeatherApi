using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherApi.Objects.SubObjects;

public class Geocode
{
    [JsonProperty("SAME")]
    public List<string> SAME { get; set; }

    [JsonProperty("UGC")]
    public List<string> UGC { get; set; }
}