using AccuWeather.Web.SkillsTest.Models.Data.Core;

namespace AccuWeather.Web.SkillsTest.Models.Data.Forecasts
{
	public class HourlyForecast
	{
		public DateTimeOffset DateTime { get; set; }
		public int EpochDateTime { get; set; }
		public bool HasPrecipitation { get; set; }
		public string? IconPhrase { get; set; }
		public bool IsDaylight { get; set; }
		public string? Link { get; set; }
		public string? MobileLink { get; set; }
		public string? PrecipitationIntensity { get; set; }
		public int PrecipitationProbability { get; set; }
		public string? PrecipitationType { get; set; }
		public Measurement? Temperature { get; set; }
		public int WeatherIcon { get; set; }
	}
}
