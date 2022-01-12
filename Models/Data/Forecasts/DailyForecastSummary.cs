namespace AccuWeather.Web.SkillsTest.Models.Data.Forecasts
{
	public class DailyForecastSummary
	{
		public DailyForecast[] DailyForecasts { get; set; } = new DailyForecast[0];
		public LocalForecastSummary? Headline { get; set; }
	}
}
