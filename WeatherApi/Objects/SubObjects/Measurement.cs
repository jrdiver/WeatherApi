using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class Measurement
{
    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("unitCode")]
    public string Unit { get; set; } = string.Empty;

    public string GetUnit()
    {
        string[] unitSplit = Unit.Split(':');
        return unitSplit.Length > 1 ? unitSplit[1].Trim() : Unit.Trim();
    }
}