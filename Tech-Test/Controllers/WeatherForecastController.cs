using Microsoft.AspNetCore.Mvc;

namespace Tech_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly Dictionary<WeatherDescription, string> WeatherDescriptionMapping = new Dictionary<WeatherDescription, string>()
        {
            { WeatherDescription.Sunny, "Sunny" },
            { WeatherDescription.Cloudy, "Cloudy" },
            { WeatherDescription.Rain, "Rain" },
            { WeatherDescription.HeavyRain, "HeavyRain" },
            { WeatherDescription.Snow, "Snow" },
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _weatherForecastService = service;
        }

        // TASK
        // CONNECT THE FOLLOWING END POINTS TO SERVICES

        [HttpGet(Name = "GetWhereHighHumidity")]
        public async Task<IActionResult> GetAllWhereHighHumidity()
        {
            return Ok();
        }

        // should only return the location names, not the full forecast
        [HttpGet(Name = "GetSunnyLocations")]
        public async Task<IActionResult> GetSunnyLocations()
        {
            return Ok();
        }

        // FOR THIS ONE, ONCE THE TEMPERATURE CLASS HAS BEEN IMPLEMENTED, ADD FLAG FOR UNIT
        [HttpGet(Name = "GetWhereTempBetween")]
        public async Task<IActionResult> GetWhereTempIsBetween(float min, float max)
        {
            return Ok();
        }

    }

    // service
    // ------------------------------------------------------------------------------------------------------

    public interface IWeatherForecastService
    {
    }

    public class WeatherForecastService : IWeatherForecastService
    {

        private static List<WeatherForecast> weatherForecasts = new List<WeatherForecast>()
        {
            new WeatherForecast(12, "Manchester", 74, WeatherDescription.Cloudy),
            new WeatherForecast(13, "Birmingham", 65, WeatherDescription.Sunny),
            new WeatherForecast(16, "Leeds", 57, WeatherDescription.Sunny),
            new WeatherForecast(22, "Warrington", 80, WeatherDescription.Rain),
            new WeatherForecast(10, "Liverpool", 78, WeatherDescription.HeavyRain),
            new WeatherForecast(8, "London", 56, WeatherDescription.Cloudy),
            new WeatherForecast(-3, "Glasgow", 85, WeatherDescription.Snow),
            new WeatherForecast(14, "Chesire", 75, WeatherDescription.Rain),
            new WeatherForecast(14, "Cardiff", 72, WeatherDescription.Rain),
            new WeatherForecast(15, "Bristol", 70, WeatherDescription.Sunny),
            new WeatherForecast(20, "Hull", 92, WeatherDescription.Sunny),
            new WeatherForecast(18, "Lincoln", 63, WeatherDescription.HeavyRain),
        };

    }

    // classes and enums
    // ------------------------------------------------------------------------------------------------------

    public enum WeatherDescription
    {
        Sunny,
        Cloudy,
        Rain,
        HeavyRain,
        Snow
    };

    public class WeatherForecast
    {
        // TASK
        // CHANGE TEMPERATURE PROPERTY TO NEW TEMPERATURE CLASS
        public float Temperature { get; set; }
        public string Location { get; set; }
        public float Humidity { get; set; }
        public WeatherDescription Description { get; set; }

        public WeatherForecast(float temperature, string location, float humidity, WeatherDescription description)
        {
            Temperature = temperature;
            Location = location;
            Humidity = humidity;
            Description = description;
        }
    }

    // TASK
    // ADD TEMPERATURE CLASS
    // PROPERTIES - TEMPERATURE, ISFARENHEIT, AND 2 UTILITIES (toFarenheit, toCelcius)
    
    // equations
    // celcius to farenheit = (c*(9/5))+32
    // farenheit to celcius = (f-32)*(9/5)
}
