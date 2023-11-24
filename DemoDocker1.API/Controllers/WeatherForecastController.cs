using Microsoft.AspNetCore.Mvc;

namespace DemoDocker1.API.Controllers;

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
    public IActionResult Api_1_GetClass_1()
    {
        DemoDockerClass1.Class1 a = new DemoDockerClass1.Class1();
        return Ok(a.Name);
    }

    [HttpGet]
    public IActionResult Api_1_GetClass_2()
    {
        DemoDockerClass2.Class1 a = new DemoDockerClass2.Class1();
        return Ok(a.Name);
    }

    [HttpGet]
    public IActionResult Api_1_GetClass_3()
    {
        DemoDockerClass3.Class1 a = new DemoDockerClass3.Class1();
        return Ok(a.Name);
    }
}
