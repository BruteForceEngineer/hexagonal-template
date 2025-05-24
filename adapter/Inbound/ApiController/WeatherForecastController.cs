using Core.Ports.Inbound.Services;
using Core.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Adapter.Inbound.ApiController
{
    [ApiController]
    [Route("api/v1")]
    public class WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        ITestService testService) : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("SomeMoreStuff")]
        public IEnumerable<WeatherForecastService> DoSomeStuff()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastService
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public string Index()
        {
            return "start";
        }
    }
}
