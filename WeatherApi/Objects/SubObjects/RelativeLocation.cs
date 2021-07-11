using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects
{
    public class RelativeLocation
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public CityInfo Properties { get; set; }
    }
}
