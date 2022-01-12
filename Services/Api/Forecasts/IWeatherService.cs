using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Forecasts
{
	public interface IForecastService
	{
		Task<DailyForecastSummary> GetDailyForecastAsync(string locationKey);

		Task<HourlyForecast[]> GetHourlyForecastAsync(string locationKey);
	}
}
