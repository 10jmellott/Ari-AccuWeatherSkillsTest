using AccuWeather.Web.SkillsTest.Models.Data.Locations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Locations
{
	public interface ILocationService
	{
		Task<Location> GetLocationAsync(string key);

		Task<List<Location>> SearchLocationsAsync(string searchTerm);
	}
}
