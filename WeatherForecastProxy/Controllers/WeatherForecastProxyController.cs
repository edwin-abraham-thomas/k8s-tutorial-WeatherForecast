using Microsoft.AspNetCore.Mvc;
namespace WeatherForecastProxy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastProxyController : ControllerBase
    {
        private readonly ILogger<WeatherForecastProxyController> _logger;

        public WeatherForecastProxyController(ILogger<WeatherForecastProxyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get()
        {
            var weatherForecastServiceURL = "http://weatherforecast:5580/WeatherForecast";
            using HttpClient client = new();
            _logger.LogInformation("Requesting weather forecast {url}", weatherForecastServiceURL);
            var response = await client.GetAsync(weatherForecastServiceURL);
            _logger.LogInformation("StatusCode {code}", response.StatusCode.ToString());
            return await response.Content.ReadAsStringAsync();
        }
    }
}