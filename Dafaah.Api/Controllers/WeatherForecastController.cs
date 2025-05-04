using Dafaah.Api.RabbitMQ;
using Dafaah.Products.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dafaah.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMessageProducer _messageProducer;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IMessageProducer messageProducer)
        {
            _logger = logger;
            _messageProducer = messageProducer;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("[action]")]
        public Task SayHello()
        {
            _messageProducer.SendMessage(new Product
            {
                Id = 1,
                Name = "mouse"
            });
            return Task.CompletedTask;
        }
    }
}
