using Microsoft.AspNetCore.Mvc;
using WeatherAppAssignment.Models;

namespace WeatherAppAssignment.ViewComponents;

public class WeatherGridViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(CityWeather city)
    {
        ViewData["TemperatureFahrenheit"] = GetCssClassByFahrenheit(city.TemperatureFahrenheit);
        return View("Sample",city);
    }
    public string GetCssClassByFahrenheit(int temp){
        if (temp < 44)
        {
            return "blue-back";
        }
        else if (temp >= 44 && temp < 74)
        {
            return "green-back";
        }
        else
        {
            return "orange-back";
        }
    }
}

