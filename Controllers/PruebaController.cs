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

    [HttpGet]
    public ActionResult<IEnumerable<String>> Get()
    {
        return Ok(new 
{
 
    Titulo = "Prueba ",
    Descripcion = "Prueba de CI / CD con Azure Devops"
}
        
    );
    }
}
