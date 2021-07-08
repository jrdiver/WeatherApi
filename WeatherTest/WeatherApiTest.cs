using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApi;
using WeatherApi.Objects;

namespace WeatherTest
{
    [TestClass]
    public class WeatherApiTest
    {
        private WeatherDotGov api = new WeatherDotGov("WeatherAppTest");
        private WeatherLocation location;
        private const double Latitude = 44.255875483521606;
        private const double Longitude = -88.46596364287998;

        [TestMethod]
        public void GetLocation()
        {
            location = api.GetLocation(Latitude, Longitude);
            Assert.AreEqual("GRB",location.gridId);
            Assert.AreEqual("KGRB",location.radarStation);
            Assert.AreEqual(64,location.gridX);
            Assert.AreEqual(18,location.gridY);
        }
    }
}
