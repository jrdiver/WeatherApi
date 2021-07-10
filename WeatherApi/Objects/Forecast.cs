using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherApi.Objects.SubObjects;

namespace WeatherApi.Objects
{
    public class Forecast
    {
        [JsonProperty("@context")]
        public List<object> Context { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Coordinates Geometry { get; set; }

        [JsonProperty("properties")]
        public ForecastInfo Properties { get; set; }
    }
}
