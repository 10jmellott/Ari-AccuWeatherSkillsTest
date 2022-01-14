namespace AccuWeather.Web.SkillsTest.Models.Data.Forecasts
{
	public class LocalForecastSummary
	{
		public string? Category { get; set; }
		public DateTimeOffset EffectiveDate { get; set; }
		public DateTimeOffset? EndDate { get; set; }
		public int Severity { get; set; }
		public string? Text { get; set; }
	}
}
