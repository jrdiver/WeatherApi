
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherApi.Objects
{
    public class Geometry
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class Distance
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
        public double value { get; set; }
        public string unitCode { get; set; }
    }

    public class Bearing
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
        public int value { get; set; }
        public string unitCode { get; set; }
    }

    public class Value
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
    }

    public class UnitCode
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class ForecastOffice
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class ForecastGridData
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class PublicZone
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class County
    {
        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class Context
    {
        [JsonProperty("@version")]
        public string Version { get; set; }
        public string wx { get; set; }
        public string s { get; set; }
        public string geo { get; set; }
        public string unit { get; set; }

        [JsonProperty("@vocab")]
        public string Vocab { get; set; }
        public Geometry geometry { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Distance distance { get; set; }
        public Bearing bearing { get; set; }
        public Value value { get; set; }
        public UnitCode unitCode { get; set; }
        public ForecastOffice forecastOffice { get; set; }
        public ForecastGridData forecastGridData { get; set; }
        public PublicZone publicZone { get; set; }
        public County county { get; set; }
    }

    public class RelativeLocation
    {
        public string city { get; set; }
        public string state { get; set; }
        public string geometry { get; set; }
        public Distance distance { get; set; }
        public Bearing bearing { get; set; }
    }

    public class WeatherLocation
    {
        [JsonProperty("@context")]
        public Context Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
        public string geometry { get; set; }
        public string cwa { get; set; }
        public string forecastOffice { get; set; }
        public string gridId { get; set; }
        public int gridX { get; set; }
        public int gridY { get; set; }
        public string forecast { get; set; }
        public string forecastHourly { get; set; }
        public string forecastGridData { get; set; }
        public string observationStations { get; set; }
        public RelativeLocation relativeLocation { get; set; }
        public string forecastZone { get; set; }
        public string county { get; set; }
        public string fireWeatherZone { get; set; }
        public string timeZone { get; set; }
        public string radarStation { get; set; }
    }


}
