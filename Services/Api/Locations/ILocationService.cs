using AccuWeather.Web.SkillsTest.Models.Data.Locations;

namespace AccuWeather.Web.SkillsTest.Services.Api.Locations
{
	public interface ILocationService
	{
		/// <summary>
		/// Gets the full details of a location based on it's AccuWeather location ID.
		/// You can find the location ID by using the SearchLocationsAsync method and
		/// pulling the Location.Key property of the desired location.
		/// </summary>
		/// <param name="key">Value from a Location.Key</param>
		/// <returns>Location if key matches an AccuWeather location, null otherwise</returns>
		Task<Location> GetLocationAsync(string key);

		/// <summary>
		/// Gets a list of locations that match the search term. Note that the search term
		/// is fairly specific, so it may not return any results with partial matches. Try
		/// using a more specific search term like 'New York' or 'London'.
		/// </summary>
		/// <param name="searchTerm">Search term you want to see locations for</param>
		/// <returns>List of locations matching the search term, or an empty list</returns>
		Task<List<Location>> SearchLocationsAsync(string searchTerm);
	}
}
