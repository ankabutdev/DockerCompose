using Microsoft.AspNetCore.Mvc;

namespace DemoDocker4.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
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
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet]
    public IActionResult Api_4_GetClass_1()
    {
        DemoDocker4Class1.Class1 a = new DemoDocker4Class1.Class1();
        return Ok(a.Name);
    }

    [HttpGet]
    public IActionResult Api_4_GetClass_2()
    {
        DemoDocker4Class2.Class1 a = new DemoDocker4Class2.Class1();
        return Ok(a.Name);
    }

    [HttpGet]
    public IActionResult Api_4_GetClass_3()
    {
        DemoDocker4Class3.Class1 a = new DemoDocker4Class3.Class1();
        return Ok(a.Name);
    }
}
