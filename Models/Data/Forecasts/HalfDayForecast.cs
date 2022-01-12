namespace AccuWeather.Web.SkillsTest.Models.Data.Forecasts
{
	public class HalfDayForecast
	{
		public bool HasPrecipitation { get; set; }
		public int Icon { get; set; }
		public string? IconPhrase { get; set; }
		public string? PrecipitationIntensity { get; set; }
		public string? PrecipitationType { get; set; }
	}
}
