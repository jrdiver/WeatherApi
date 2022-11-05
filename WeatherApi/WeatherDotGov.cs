using System;
using System.Diagnostics;
using Newtonsoft.Json;
using WeatherApi.Class;
using WeatherApi.Objects;

namespace WeatherApi;

public class WeatherDotGov
{
    /// <summary> Api URL </summary>
    public string BaseUrl
    {
        get => API.BaseUrl;
        set => API.BaseUrl = value;
    }

    /// <summary> Sent as the User Agent.  As Weather.Gov lists - "If you include contact information (website or email), we can contact you if your string is associated to a security event" </summary>
    public string AppNameIdentifier
    {
        get => API.AppNameIdentifier;
        set => API.AppNameIdentifier = value;
    }

    internal WebConnect API = new();
    public WeatherLocation Location = new();


    public WeatherDotGov(string appNameIdentifier)
    {
        AppNameIdentifier = appNameIdentifier;
    }

    public WeatherLocation GetLocation(double latitude, double longitude)
    {
        string response = API.GetUrl("points/" + latitude + "," + longitude);
        try
        {
            Location = JsonConvert.DeserializeObject<WeatherLocation>(response);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        if (Location == null || string.IsNullOrWhiteSpace(Location.PointsLink))
        {
            ErrorAnswer error = LoadError(response);
            throw new ArgumentException(error.Detail);
        }
        Location.Latitude = latitude;
        Location.Longitude = longitude;
        return Location;
    }

    public WeatherAlert GetAlerts(double latitude, double longitude, DateTime startTime, DateTime endTime)
    {
        string response = API.GetUrl($"alerts?point={Math.Round(latitude,3)},{Math.Round(longitude, 3)}&start={startTime.ToUniversalTime():yyyy-MM-ddThh:mm:ss}Z&end={endTime.ToUniversalTime():yyyy-MM-ddThh:mm:ss}Z");
        WeatherAlert alert = new();
        try
        {
            alert = JsonConvert.DeserializeObject<WeatherAlert>(response);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        if (alert == null || alert.UpdatedTime == DateTime.MinValue)
        {
            ErrorAnswer error = LoadError(response);
        }
        return alert;
    }

    public Forecast GetForecast()
    {
        string response = API.GetUrl(Location.Properties.ForecastUrl, false);
        Forecast forecast = JsonConvert.DeserializeObject<Forecast>(response);
        return forecast;
    }

    public Forecast GetHourByHour()
    {
        string response = API.GetUrl(Location.Properties.ForecastHourlyUrl, false);
        Forecast forecast = JsonConvert.DeserializeObject<Forecast>(response);
        return forecast;
    }

    internal ErrorAnswer LoadError(string errorMessage)
    {
        ErrorAnswer error;
        try
        {
            error = JsonConvert.DeserializeObject<ErrorAnswer>(errorMessage);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            throw new ArgumentException("The Response Provided was invalid");
        }
        return error;
    }
}