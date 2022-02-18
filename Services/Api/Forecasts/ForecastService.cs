using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;
using AccuWeather.Web.SkillsTest.Services.Api.Core;

namespace AccuWeather.Web.SkillsTest.Services.Api.Forecasts
{
	public class ForecastService : IForecastService
	{
		private readonly IAccuWeatherApiService _ApiService;

		public ForecastService(IAccuWeatherApiService apiService)
		{
			_ApiService = apiService;
		}

		public Task<DailyForecastSummary?> GetDailyForecastAsync(string locationKey)
		{
			return _ApiService.GetAccuWeatherApiAsync<DailyForecastSummary>($"/forecasts/v1/daily/5day/{locationKey}");
		}

		public Task<HourlyForecast[]?> GetHourlyForecastAsync(string locationKey)
		{
			return _ApiService.GetAccuWeatherApiAsync<HourlyForecast[]>($"/forecasts/v1/hourly/12hour/{locationKey}");
		}
	}
}
