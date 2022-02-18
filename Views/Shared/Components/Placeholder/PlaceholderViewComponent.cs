using AccuWeather.Web.SkillsTest.Services.Api.Locations;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.Placeholder
{
	public class PlaceholderViewComponent : ViewComponent
	{
		private readonly ILocationService _LocationService;

		public PlaceholderViewComponent(ILocationService locationService)
		{
			_LocationService = locationService;
		}

		public async Task<IViewComponentResult> InvokeAsync(string? text = null)
		{
			// 35315 is the AccuWeather location key for State College, Pennsylvania, United States
			var location = await _LocationService.GetLocationAsync("335315");
			return View<string>(location?.DisplayName ?? text);
		}
	}
}
