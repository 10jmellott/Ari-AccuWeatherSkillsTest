using AccuWeather.Web.SkillsTest.Services.Api.Locations;
using AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions;
using AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.CurrentConditions
{
	public class CurrentConditionsViewComponent : ViewComponent
	{
		private readonly ILocationService _LocationService;
		private readonly ICurrentConditionsService _CurrentConditionsService;
		private readonly ILogger<CurrentConditionsViewComponent> _logger;

		public CurrentConditionsViewComponent(ILocationService locationService, ICurrentConditionsService currentConditionsService, ILogger<CurrentConditionsViewComponent> logger)
		{
			_LocationService = locationService;
			_CurrentConditionsService = currentConditionsService;
			_logger = logger;

		}

		public async Task<IViewComponentResult> InvokeAsync(string? text = null)
		{
			var saved_location = HttpContext.Request.Cookies["location"];
			var conditions = await _CurrentConditionsService.GetCurrentConditionsAsync(saved_location ?? "");
			_logger.LogInformation(conditions?.ToString());
			return View<WeatherObservation>(conditions?? new WeatherObservation());
		}
	}
}
