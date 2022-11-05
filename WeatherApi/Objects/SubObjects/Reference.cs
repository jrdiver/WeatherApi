using Newtonsoft.Json;
using System;

namespace WeatherApi.Objects.SubObjects
{
    public class Reference
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("sent")]
        public DateTime Sent { get; set; }
    }
}
