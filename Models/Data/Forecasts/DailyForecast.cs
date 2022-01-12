using AccuWeather.Web.SkillsTest.Models.Data.Core;

namespace AccuWeather.Web.SkillsTest.Models.Data.Forecasts
{
	public class DailyForecast
	{
		public DateTimeOffset Date { get; set; }
		public HalfDayForecast Day { get; set; } = new HalfDayForecast();
		public HalfDayForecast Night { get; set; } = new HalfDayForecast();
		public MeasurementRange? Temperature { get; set; }
	}
}
