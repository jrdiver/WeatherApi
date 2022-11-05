using Newtonsoft.Json;

namespace WeatherApi.Objects.SubObjects;

public class ForecastLinks
{

    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("cwa")]
    public string Cwa { get; set; }

    [JsonProperty("forecastOffice")]
    public string ForecastOffice { get; set; }

    [JsonProperty("gridId")]
    public string GridOffice { get; set; }

    [JsonProperty("gridX")]
    public int GridX { get; set; }

    [JsonProperty("gridY")]
    public int GridY { get; set; }

    [JsonProperty("forecast")]
    public string ForecastUrl { get; set; }

    [JsonProperty("forecastHourly")]
    public string ForecastHourlyUrl { get; set; }

    [JsonProperty("forecastGridData")]
    public string ForecastGridDataUrl { get; set; }

    [JsonProperty("observationStations")]
    public string ObservationStationsUrl { get; set; }

    [JsonProperty("relativeLocation")]
    public RelativeLocation RelativeLocation { get; set; }

    [JsonProperty("forecastZone")]
    public string ForecastZoneUrl { get; set; }

    [JsonProperty("county")]
    public string CountyUrl { get; set; }

    [JsonProperty("fireWeatherZone")]
    public string FireWeatherZoneUrl { get; set; }

    [JsonProperty("timeZone")]
    public string TimeZone { get; set; }

    [JsonProperty("radarStation")]
    public string RadarStation { get; set; }
}