using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects
{
    public class Coordinates
    {

        [JsonProperty("type")]
        public string Shape { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<double>>> CoordinateList { get; set; }
    }
}
