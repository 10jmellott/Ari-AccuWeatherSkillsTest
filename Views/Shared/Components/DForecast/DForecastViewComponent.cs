using AccuWeather.Web.SkillsTest.Services.Api.Forecasts;
using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.DForecast
{
	public class DForecastViewComponent : ViewComponent
	{
		private readonly IForecastService _ForecastService;

		public DForecastViewComponent(IForecastService forecastService)
		{
			_ForecastService = forecastService;

		}

		public async Task<IViewComponentResult> InvokeAsync(int days = 5)
		{
			var saved_location = HttpContext.Request.Cookies["location"];
			var dailyForecast = await _ForecastService.GetDailyForecastAsync(saved_location ?? "");
			if(dailyForecast?.DailyForecasts?.Length > days) {
				dailyForecast.DailyForecasts = dailyForecast.DailyForecasts.Take(days).ToArray();
			}
			return View<DailyForecastSummary>(dailyForecast?? new DailyForecastSummary());
		}
	}
}
