using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects
{
    public class CityInfo
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("distance")]
        public Measurement Distance { get; set; }

        [JsonProperty("bearing")]
        public Measurement Bearing { get; set; }
    }
}
