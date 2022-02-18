using System.Text.Json;

namespace AccuWeather.Web.SkillsTest.Services.Api.Core
{
	public class AccuWeatherApiService : IAccuWeatherApiService
	{
		private readonly (string key, string value)[] _ApiKey;
		private readonly string? _Host;
		private readonly IHttpClientFactory _HttpClientFactory;
		private readonly ILogger<AccuWeatherApiService> _Logger;

		public AccuWeatherApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<AccuWeatherApiService> logger)
		{
			_HttpClientFactory = httpClientFactory;
			_Logger = logger;

			_Host = configuration["AccuWeather:Host"];
			var apiKey = configuration["AccuWeather:Key"];

			if (string.IsNullOrWhiteSpace(apiKey))
				throw new NotImplementedException($"AccuWeather:Key is not set in the appsettings.json file");

			_ApiKey = new (string key, string value)[] { ("apikey", apiKey) };
		}

		public async Task<T?> GetAccuWeatherApiAsync<T>(string path, params (string key, string value)[] queries)
		{
			// TODO: Make API calls robust against failure
			using (var client = _HttpClientFactory.CreateClient())
			{
				// Create the URL
				var url = _Host + path;
				queries = queries.Concat(_ApiKey).ToArray();
				var queryString = string.Join("&", queries.Select(param => $"{param.key}={param.value}"));
				if (!string.IsNullOrWhiteSpace(queryString)) url += $"?{queryString}";

				// Make the request
				var response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					var stream = await response.Content.ReadAsStreamAsync();
					if (stream is not null) return await JsonSerializer.DeserializeAsync<T>(stream);
				}
			}

			return default(T);
		}
	}
}
