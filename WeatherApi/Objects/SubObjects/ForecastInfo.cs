using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class ForecastInfo
{
    [JsonProperty("updated")]
    public DateTime Updated { get; set; }

    [JsonProperty("units")]
    public string Units { get; set; }

    [JsonProperty("forecastGenerator")]
    public string ForecastGenerator { get; set; }

    [JsonProperty("generatedAt")]
    public DateTime GeneratedAt { get; set; }

    [JsonProperty("updateTime")]
    public DateTime UpdateTime { get; set; }

    [JsonProperty("validTimes")]
    public string ValidTimes { get; set; }

    [JsonProperty("elevation")]
    public Measurement Elevation { get; set; }

    [JsonProperty("periods")]
    public List<PeriodForecast> Periods { get; set; }
}