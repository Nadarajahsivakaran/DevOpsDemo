using DevOpsDemo.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace DevOpsDemo.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsWeatherForecast()
        {
            // 1. Mock the logger
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();

            // 2. Pass the mock to the controller
            var controller = new WeatherForecastController(mockLogger.Object);

            // 3. Call the action
            var result = controller.Get();

            // 4. Assert the result
            Assert.NotEmpty(result);
        }
    }
}