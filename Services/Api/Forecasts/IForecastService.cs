using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;

namespace AccuWeather.Web.SkillsTest.Services.Api.Forecasts
{
	public interface IForecastService
	{
		/// <summary>
		/// Gets the next 5 days of daily forecasts for the provided location
		/// </summary>
		/// <param name="locationKey">Key property from a Location object</param>
		/// <returns>List of daily forecasts, or null on failure</returns>
		Task<DailyForecastSummary?> GetDailyForecastAsync(string locationKey);

		/// <summary>
		/// Gets the next 12 hours of hourly forecasts for the provided location
		/// </summary>
		/// <param name="locationKey">Key property from a Location object</param>
		/// <returns>List of hourly forecasts, or an empty array on failure</returns>
		Task<HourlyForecast[]?> GetHourlyForecastAsync(string locationKey);
	}
}
