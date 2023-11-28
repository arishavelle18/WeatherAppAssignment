using Microsoft.AspNetCore.Mvc;
using WeatherAppAssignment.Models;

namespace WeatherAppAssignment.ViewComponents;

public class WeatherGridViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(List<CityWeather> grid)
    {
        return View("Sample");
    }
}

