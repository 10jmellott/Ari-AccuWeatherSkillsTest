using AccuWeather.Web.SkillsTest.Services.Api.Forecasts;
using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.HForecast
{
	public class HForecastViewComponent : ViewComponent
	{
		private readonly IForecastService _HourlyForecastService;

		public HForecastViewComponent(IForecastService hourlyForecastService)
		{
			_HourlyForecastService = hourlyForecastService;

		}

		public async Task<IViewComponentResult> InvokeAsync(int hours = 12)
		{
			var saved_location = HttpContext.Request.Cookies["location"];
			var hourlyForecasts = await _HourlyForecastService.GetHourlyForecastAsync(saved_location ?? "");
			if(hourlyForecasts?.Length > hours) {
				hourlyForecasts = hourlyForecasts.Take(hours).ToArray();
			}
			return View<HourlyForecast[]>(hourlyForecasts?? new HourlyForecast[0]);
		}
	}
}
