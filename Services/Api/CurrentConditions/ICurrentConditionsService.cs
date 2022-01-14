using AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions;

namespace AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions
{
	public interface ICurrentConditionsService
	{
		/// <summary>
		/// Gets the current weather conditions for the provided location
		/// </summary>
		/// <param name="locationKey">Key property from a Location object</param>
		/// <returns>Current conditions of the provided location, or null on failure</returns>
		Task<WeatherObservation?> GetCurrentConditionsAsync(string locationKey);
	}
}
