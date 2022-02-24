using AccuWeather.Web.SkillsTest.Services.Api.Forecasts;
using AccuWeather.Web.SkillsTest.Models.Data.Forecasts;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.DPrecipitation
{
	public class DPrecipitationViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(HalfDayForecast? halfDayForecast = null, string? label = "")
		{
			return View(new Tuple<HalfDayForecast, string>(halfDayForecast?? new HalfDayForecast(), label?? ""));
		}
	}
}
