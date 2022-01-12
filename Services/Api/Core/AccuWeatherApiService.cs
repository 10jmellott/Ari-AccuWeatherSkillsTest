using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AccuWeather.Web.SkillsTest.Services.Api.Core
{
	public class AccuWeatherApiService : IAccuWeatherApiService
	{
		private readonly string? _ApiKey;
		private readonly IHttpClientFactory _HttpClientFactory;
		private readonly ILogger<AccuWeatherApiService> _Logger;

		public AccuWeatherApiService(IHttpClientFactory httpClientFactory, ILogger<AccuWeatherApiService> logger)
		{
			_HttpClientFactory = httpClientFactory;
			_Logger = logger;

			// TODO: Set the API Key from appsettings.json
			// _ApiKey = ...
			throw new NotImplementedException($"{nameof(_ApiKey)} is not set.");
		}

		public Task<T> GetAccuWeatherApiAsync<T>(string path, params (string key, string value)[] queries)
		{
			throw new NotImplementedException("GetAccuWeatherApiAsync is not implemented");
			// TODO: Make an API call from the path & query parameters provided
		}
	}
}
