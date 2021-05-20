using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SimpleAPI.Controllers;
using Moq;

namespace SimpleAPI.Test
{
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController controller;
        private Mock<ILogger<WeatherForecastController>> mockLogger;
        [SetUp]
        public void Setup()
        {
            mockLogger = new Mock<ILogger<WeatherForecastController>>();
            controller = new WeatherForecastController(mockLogger.Object);            
        }

        [Test]
        public void WeatherForecastController_Get_ReturnsObject()
        {
            var result = controller.Get();
            Assert.IsNotNull(result);
        }
        [Test]
        public void WeatherForecastController_Get_Returns5()
        {
            var expectedCount = 5;
            var result = (WeatherForecast[]) controller.Get();

            Assert.AreEqual(expectedCount, result.Length);
        }
    }
}