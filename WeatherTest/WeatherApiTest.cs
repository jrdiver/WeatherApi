using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherApi;
using WeatherApi.Objects;

namespace WeatherTest
{
    [TestClass]
    public class WeatherApiTest
    {
        private readonly WeatherDotGov api = new WeatherDotGov("WeatherAppTest");
        private const double Latitude = 44.255875483521606;
        private const double Longitude = -88.46596364287998;
        private readonly WeatherLocation location;

        public WeatherApiTest()
        {
            location = api.GetLocation(Latitude, Longitude);
        }

        [TestMethod]
        public void GetLocation()
        {
            Assert.AreEqual("GRB",location.Properties.GridOffice);
            Assert.AreEqual("KGRB",location.Properties.RadarStation);
            Assert.AreEqual(64,location.Properties.GridX);
            Assert.AreEqual(18,location.Properties.GridY);
        }
    }
}
