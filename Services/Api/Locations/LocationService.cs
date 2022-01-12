using AccuWeather.Web.SkillsTest.Models.Data.Locations;
using AccuWeather.Web.SkillsTest.Services.Api.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Locations
{
	public class LocationService : ILocationService
	{
		private readonly IAccuWeatherApiService _ApiService;

		public LocationService(IAccuWeatherApiService apiService)
		{
			_ApiService = apiService;
		}

		public Task<Location> GetLocationAsync(string key)
		{
			return _ApiService.GetAccuWeatherApiAsync<Location>($"/locations/v1/{key}");
		}

		public Task<List<Location>> SearchLocationsAsync(string searchTerm)
		{
			return _ApiService.GetAccuWeatherApiAsync<List<Location>>("/locations/v1/search", ("q", searchTerm));
		}
	}
}