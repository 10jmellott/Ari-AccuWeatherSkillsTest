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

	[HttpGet("/hello")]
	public IActionResult Hello()
	{
		var loc = HttpContext.Request.Cookies.Count();
		_logger.LogInformation("from home" + loc);
		return Ok("Hello");
	}

	[HttpGet("/searchlocation")]
	public async Task<IActionResult> SearchLocation(string key)
	{
		var location = await _LocationService.SearchLocationsAsync(key);
		return Ok(location);
	}

	[HttpGet("/alerts")]
	public async Task<IActionResult> GetAlerts(string key)
	{
		var alerts = await _AlertsService.GetAlertsAsync(key);
		return Ok(alerts);
	}

	[HttpGet("/hourlyforecast")]
	public async Task<IActionResult> GetHourlyForecast(string key)
	{
		var hourly = await _ForecastService.GetHourlyForecastAsync(key);
		return Ok(hourly);
	}
	[HttpGet("/dailyforecast")]
	public async Task<IActionResult> GetDailyForecast(string key)
	{
		var daily = await _ForecastService.GetDailyForecastAsync(key);
		return Ok(daily);
	}
}
