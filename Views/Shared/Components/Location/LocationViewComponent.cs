using AccuWeather.Web.SkillsTest.Services.Api.Locations;
using AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.Location
{
	public class LocationViewComponent : ViewComponent
	{
		private readonly ILocationService _LocationService;
		private readonly ICurrentConditionsService _CurrentConditionsService;

		public LocationViewComponent(ILocationService locationService, ICurrentConditionsService currentConditionsService)
		{
			_LocationService = locationService;
			_CurrentConditionsService = currentConditionsService;
		}

		public async Task<IViewComponentResult> InvokeAsync(string? text = null)
		{
			// 35315 is the AccuWeather location key for State College, Pennsylvania, United States
			var saved_location = HttpContext.Request.Cookies["location"];
			var location = await _LocationService.GetLocationAsync(saved_location ?? "");
			return View<string>(location?.DisplayName ?? text);
		}
	}
}