using Microsoft.AspNetCore.Mvc;

namespace monografia.Controllers;

[ApiController]
[Route("[controller]")]
public class PruebaController : ControllerBase
{
  
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<String> Get()
    {
        return    new[]
    {
        "Commit", "De", "Prueba", "CI", "CD", "Azure", "Devops"
    };
    }
}
