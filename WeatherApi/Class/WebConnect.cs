using System;
using System.IO;
using System.Net;

namespace WeatherApi.Class;

internal class WebConnect
{
    /// <summary> Api URL </summary>
    public string BaseUrl = "https://api.weather.gov/";
    /// <summary> Sent as the User Agent.  As Weather.Gov lists - "If you include contact information (website or email), we can contact you if your string is associated to a security event" </summary>
    public string AppNameIdentifier = string.Empty;
    private WebClient client = new();

    /// <summary> Loads a the specified URL </summary>
    internal string GetUrl(string url, bool useBaseUrl = true)
    {
        if (string.IsNullOrWhiteSpace(BaseUrl) || string.IsNullOrWhiteSpace(AppNameIdentifier))
        {
            return "Error: BaseUrl and AppNameIdentifier Must both be set.";
        }
        try
        {
            if (useBaseUrl)
            {
                url = BaseUrl + url;
            }

            client = new WebClient();
            client.Headers.Add("user-agent", AppNameIdentifier);
            client.Credentials = CredentialCache.DefaultCredentials;
            Stream data = client.OpenRead(url);
            StreamReader reader = new(data ?? throw new InvalidOperationException());
            return reader.ReadToEnd();
        }
        catch (WebException ex)
        {
            Stream stream = ex.Response.GetResponseStream();
            if (stream == null) return "Error: Something Happened." + Environment.NewLine + ex;

            using StreamReader r = new(stream);
            return r.ReadToEnd();

        }
    }
}