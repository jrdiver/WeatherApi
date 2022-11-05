using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApi;
using WeatherApi.Objects;

namespace WeatherTest;

[TestClass]
public class WeatherApiTest
{
    private readonly WeatherDotGov api = new("WeatherAppTest");
    private const double Latitude = 44.255875483521606;
    private const double Longitude = -88.46596364287998;
    private WeatherLocation location;

    public WeatherApiTest()
    {
        location = api.GetLocation(Latitude, Longitude);
    }

    [TestMethod]
    public void A_GetLocation()
    {
        location = api.GetLocation(Latitude, Longitude);
        Assert.AreEqual("GRB", location.Properties.GridOffice);
        Assert.AreEqual("KGRB", location.Properties.RadarStation);
        Assert.AreEqual(64, location.Properties.GridX);
        Assert.AreEqual(18, location.Properties.GridY);
        Assert.AreEqual(Latitude, location.Latitude);
        Assert.AreEqual(Longitude, location.Longitude);

        try
        {
            location = api.GetLocation(11.145, 11.111);
            Assert.IsTrue(false);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Assert.IsTrue(true);
        }
    }

    [TestMethod]
    public void B_GetAlerts()
    {
        DateTime time = DateTime.Now;
        WeatherAlert forecast = api.GetAlerts(Latitude, Longitude, time.AddDays(-7), DateTime.Now);
        Assert.IsTrue( forecast.UpdatedTime > DateTime.MinValue);
    }
    [TestMethod]
    public void B_GetForecast()
    {
        Forecast forecast = api.GetForecast();
        Assert.AreEqual(14, forecast.Properties.Periods.Count);
    }

    [TestMethod]
    public void B_GetHourByHour()
    {
        Forecast forecast = api.GetHourByHour();
        Assert.AreEqual(156, forecast.Properties.Periods.Count);
    }
}