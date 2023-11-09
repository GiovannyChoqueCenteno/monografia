using Microsoft.AspNetCore.Mvc;

namespace monografia.Controllers;

[ApiController]
[Route("[controller]")]
public class PruebaController : ControllerBase
{
  
    private readonly ILogger<PruebaController> _logger;

    public PruebaController(ILogger<PruebaController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<String> Get()
    {
        return    new List
    {
        "Commit", "De", "Prueba", "CI", "CD", "Azure", "Devops"
    };
    }
}
