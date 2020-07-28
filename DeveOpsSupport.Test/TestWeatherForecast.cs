using DevOpsSupportPOC;
using DevOpsSupportPOC.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DeveOpsSupport.Test
{
    public class TestWeatherForecast
    {
        [Fact]
        public void IndexGet_Returns_ListofWeatherForecast()
        {
            //Arrange
            var mockRepo = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockRepo.Object);

            //Act
            var result = controller.Get();

            // Assert
            var viewResult = Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
            Assert.Equal(5, viewResult.Count());
        }
    }
}
