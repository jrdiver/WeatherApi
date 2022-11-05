using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherApi.Objects.SubObjects;

public class Parameters
{
    [JsonProperty("AWIPSidentifier")]
    public List<string> AWIPSidentifier { get; set; }

    [JsonProperty("WMOidentifier")]
    public List<string> WMOidentifier { get; set; }

    [JsonProperty("NWSheadline")]
    public List<string> NWSheadline { get; set; }

    [JsonProperty("BLOCKCHANNEL")]
    public List<string> BLOCKCHANNEL { get; set; }

    [JsonProperty("EAS-ORG")]
    public List<string> EASORG { get; set; }

    [JsonProperty("VTEC")]
    public List<string> VTEC { get; set; }

    [JsonProperty("eventEndingTime")]
    public List<DateTime> EventEndingTime { get; set; }

    [JsonProperty("expiredReferences")]
    public List<string> ExpiredReferences { get; set; }
}