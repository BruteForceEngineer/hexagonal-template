using Core.Ports.Inbound.Services;
using Microsoft.AspNetCore.Mvc;

namespace startup.Controllers
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
        public IEnumerable<WeatherForecast> DoSomeStuff()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
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
            return testService.GetSectionString() ?? "Not good";
        }
    }
}
