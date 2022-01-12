using AccuWeather.Web.SkillsTest.Models.Data.Alerts;
using AccuWeather.Web.SkillsTest.Services.Api.Core;

namespace AccuWeather.Web.SkillsTest.Services.Api.Alerts
{
	public class AlertsService : IAlertsService
	{
		private readonly IAccuWeatherApiService _ApiService;

		public AlertsService(IAccuWeatherApiService apiService)
		{
			_ApiService = apiService;
		}

		public Task<WeatherAlert[]> GetAlertsAsync(string locationKey)
		{
			return _ApiService.GetAccuWeatherApiAsync<WeatherAlert[]>($"/alerts/v1/{locationKey}");
		}
	}
}
