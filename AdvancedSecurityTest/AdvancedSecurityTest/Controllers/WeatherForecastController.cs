using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace AdvancedSecurityTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public const string DefaultCertificatePassword = "C0mpl1c4t3d57r1ng";
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var stream = new MemoryStream();
            var streamReader = new StreamReader(stream);
            streamReader.Read();
            GetValue();
            var mode = CipherMode.ECB;
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public static string GetValue()
        {
            return "blabla";
        }

        public void DoLogin()
        {

        }
    }
}