using Microsoft.AspNetCore.Mvc;
using AccuWeather.Web.SkillsTest.Services.Api.Locations;

namespace AccuWeather.Web.SkillsTest.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	private readonly ILocationService _LocationService;

	public HomeController(ILogger<HomeController> logger, ILocationService locationService)
	{
		_logger = logger;
		_LocationService = locationService;
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
}
