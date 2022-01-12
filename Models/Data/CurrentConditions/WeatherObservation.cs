using AccuWeather.Web.SkillsTest.Models.Data.Core;

namespace AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions
{
	public class WeatherObservation
	{
		public DateTimeOffset LocalObservationDateTime { get; set; }
		public Measurements? Temperature { get; set; }
		public int WeatherIcon { get; set; }
		public string? WeatherText { get; set; }
	}
}
