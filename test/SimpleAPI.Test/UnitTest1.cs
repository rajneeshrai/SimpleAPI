using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);
        [Fact]
        public void GetReturnMyName()
        {
            var result = controller.Get();
            Assert.Equal("Freezing", result.FirstOrDefault()?.Summary);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
