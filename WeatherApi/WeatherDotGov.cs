using System;
using System.Diagnostics;
using Newtonsoft.Json;
using WeatherApi.Class;
using WeatherApi.Objects;

namespace WeatherApi
{
    public class WeatherDotGov
    {
        /// <summary> Api URL </summary>
        public string BaseUrl = "https://api.weather.gov/";
        /// <summary> Sent as the User Agent.  As Weather.Gov lists - "If you include contact information (website or email), we can contact you if your string is associated to a security event" </summary>
        public string AppNameIdentifier;
        internal WebConnect API = new WebConnect();
        public WeatherLocation Location = new WeatherLocation();


        public WeatherDotGov(string appNameIdentifier)
        {
            AppNameIdentifier = appNameIdentifier;
            LoadSettingsToWebConnect();
        }

        public WeatherLocation GetLocation(double latitude, double longitude)
        {
            string response = API.GetUrl("points/" + latitude + "," + longitude);
            Location = JsonConvert.DeserializeObject<WeatherLocation>(response);
            return Location;
        }


        internal void LoadSettingsToWebConnect()
        {
            API.AppNameIdentifier = AppNameIdentifier;
            API.BaseUrl = BaseUrl;
        }
    }
}
