using Microsoft.AspNetCore.Mvc;
using AccuWeather.Web.SkillsTest.Services.Api.Locations;
using AccuWeather.Web.SkillsTest.Services.Api.Alerts;
using AccuWeather.Web.SkillsTest.Services.Api.Forecasts;

namespace AccuWeather.Web.SkillsTest.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	private readonly ILocationService _LocationService;
	private readonly IAlertsService _AlertsService;
	private readonly IForecastService _ForecastService;

	public HomeController(ILogger<HomeController> logger, ILocationService locationService, IAlertsService alertsService, IForecastService forecastService)
	{
		_logger = logger;
		_LocationService = locationService;
		_AlertsService = alertsService;
		_ForecastService = forecastService;
	}

	public IActionResult Index()
	{
		return View();
	}

	[HttpGet("/searchlocation")]
	public async Task<IActionResult> SearchLocation(string key)
	{
		var location = await _LocationService.SearchLocationsAsync(key);
		return Ok(location);
	}
}
