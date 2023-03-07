using Microsoft.AspNetCore.Mvc;
using MyApi1.Exceptions;
using MyApi1.Service;
using Newtonsoft.Json;
using Serilog;

namespace MyApi1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ITestService _testService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        ITestService testService
    )
    {
        _logger = logger;
        _testService = testService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ContentResult Get()
    {
        throw new HttpResponseException(500, "Get error");

        // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        // {
        //     Date = DateTime.Now.AddDays(index),
        //     TemperatureC = Random.Shared.Next(-20, 55),
        //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        // })
        // .ToArray();

        //string month = string.Format("{0:00}", DateTime.Now.AddMonths(-1).Month);

        var html = System.IO.File.ReadAllText(@"./html/index.html");
        return base.Content(html, "text/html");
    }

    [HttpPost]
    public IActionResult Post([FromBody] Pa para)
    {
        int[] ns = _testService.ThrowRandom3(para.max, para.min);
        string json = JsonConvert.SerializeObject(ns);

        return Ok(json); // "{ 91, 71, 75 }"
    }
}

public class Pa
{
    public int max { get; set; }
    public int min { get; set; }
}
