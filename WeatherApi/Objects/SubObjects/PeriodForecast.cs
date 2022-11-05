using System;
using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class PeriodForecast
{
    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("startTime")]
    public DateTime StartTime { get; set; }

    [JsonProperty("endTime")]
    public DateTime EndTime { get; set; }

    [JsonProperty("isDaytime")]
    public bool IsDaytime { get; set; }

    [JsonProperty("temperature")]
    public int Temperature { get; set; }

    [JsonProperty("temperatureUnit")]
    public string TemperatureUnit { get; set; }

    [JsonProperty("temperatureTrend")]
    public object TemperatureTrend { get; set; }

    [JsonProperty("windSpeed")]
    public string WindSpeed { get; set; }

    [JsonProperty("windDirection")]
    public string WindDirection { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("shortForecast")]
    public string ShortForecast { get; set; }

    [JsonProperty("detailedForecast")]
    public string DetailedForecast { get; set; }
}