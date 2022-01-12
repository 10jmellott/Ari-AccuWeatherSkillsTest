using AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions;
using AccuWeather.Web.SkillsTest.Services.Api.Core;
using System.Linq;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions
{
	public class CurrentConditionsService : ICurrentConditionsService
	{
		private readonly IAccuWeatherApiService _ApiService;

		public CurrentConditionsService(IAccuWeatherApiService apiService)
		{
			_ApiService = apiService;
		}

		public async Task<WeatherObservation?> GetCurrentConditionsAsync(string locationKey)
		{
			return (await _ApiService.GetAccuWeatherApiAsync<WeatherObservation[]>($"/currentconditions/v1/{locationKey}"))?.FirstOrDefault();
		}
	}
}
