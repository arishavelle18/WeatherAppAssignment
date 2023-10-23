using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WeatherAppAssignment.Models;

namespace WeatherAppAssignment.Controllers;

public class WeatherController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        List<CityWeather> weatherData = new List<CityWeather>()
        {
            new CityWeather {CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
            new CityWeather {CityUniqueCode = "NYC", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
            new CityWeather {CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
        };
        return View(weatherData);
    }

    [Route("/weather/{cityCode}")]
    public IActionResult ViewDetails(string? cityCode)
    {
        List<CityWeather> weatherData = new List<CityWeather>()
        {
            new CityWeather {CityUniqueCode = "LDN", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 8:00"),  TemperatureFahrenheit = 33},
            new CityWeather {CityUniqueCode = "NYC", CityName = "London", DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
            new CityWeather {CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
        };

        CityWeather? mathchingCity = weatherData.Where(city => city.CityUniqueCode == cityCode).FirstOrDefault();

        return View(mathchingCity);
    }
}

