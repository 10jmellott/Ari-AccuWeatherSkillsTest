using AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions
{
	public interface ICurrentConditionsService
	{
		Task<WeatherObservation?> GetCurrentConditionsAsync(string locationKey);
	}
}
