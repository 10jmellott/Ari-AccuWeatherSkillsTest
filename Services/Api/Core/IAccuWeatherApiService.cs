using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Core
{
	public interface IAccuWeatherApiService
	{
		Task<T> GetAccuWeatherApiAsync<T>(string path, params (string key, string value)[] queries);
	}
}
