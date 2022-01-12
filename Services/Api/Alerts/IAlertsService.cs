using AccuWeather.Web.SkillsTest.Models.Data.Alerts;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Alerts
{
	public interface IAlertsService
	{
		Task<WeatherAlert[]> GetAlertsAsync(string locationKey);
	}
}
