using AccuWeather.Web.SkillsTest.Services.Api.Alerts;
using AccuWeather.Web.SkillsTest.Models.Data.Alerts;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.WeatherAlerts
{
	public class WeatherAlertsViewComponent : ViewComponent
	{
		private readonly IAlertsService _WeatherAlertsService;

		public WeatherAlertsViewComponent(IAlertsService weatherAlertService)
		{
			_WeatherAlertsService = weatherAlertService;

		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var saved_location = HttpContext.Request.Cookies["location"];
			var weatherAlerts = await _WeatherAlertsService.GetAlertsAsync(saved_location ?? "");
			return View<WeatherAlert[]>(weatherAlerts?? new WeatherAlert[0]);
		}
	}
}
