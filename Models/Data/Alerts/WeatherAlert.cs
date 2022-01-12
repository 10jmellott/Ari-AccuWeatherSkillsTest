namespace AccuWeather.Web.SkillsTest.Models.Data.Alerts
{
	public class WeatherAlert
	{
		public AlertArea[] Area { get; set; } = new AlertArea[0];
		public AlertDescription? Description { get; set; }
	}
}
