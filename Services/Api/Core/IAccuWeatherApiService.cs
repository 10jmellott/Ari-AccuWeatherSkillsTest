namespace AccuWeather.Web.SkillsTest.Services.Api.Core
{
	public interface IAccuWeatherApiService
	{
		/// <summary>
		/// Forms the foundation for making API calls to the AccuWeather API
		/// when provided with the path and query parameters to be sent to AccuWeather
		/// </summary>
		/// <typeparam name="T">Enable transforming the JSON response to any object</typeparam>
		/// <param name="path">The PATH of the URL</param>
		/// <param name="queries">The QUERY parameters (if any) of the URL</param>
		/// <returns></returns>
		Task<T?> GetAccuWeatherApiAsync<T>(string path, params (string key, string value)[] queries);
	}
}
