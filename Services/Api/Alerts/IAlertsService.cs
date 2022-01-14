using AccuWeather.Web.SkillsTest.Models.Data.Alerts;

namespace AccuWeather.Web.SkillsTest.Services.Api.Alerts
{
	public interface IAlertsService
	{
		/// <summary>
		/// Gets the current active or upcoming weather alerts for a location from
		/// the location's national government weather reporting agency.
		/// </summary>
		/// <param name="locationKey">Key property from a Location object</param>
		/// <returns>List of active government weather alerts for the location, or an empty array on failure</returns>
		Task<WeatherAlert[]> GetAlertsAsync(string locationKey);
	}
}
