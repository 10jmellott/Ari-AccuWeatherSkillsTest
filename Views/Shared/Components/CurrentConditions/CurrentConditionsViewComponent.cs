using AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions;
using AccuWeather.Web.SkillsTest.Models.Data.CurrentConditions;
using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.CurrentConditions
{
	public class CurrentConditionsViewComponent : ViewComponent
	{
		private readonly ICurrentConditionsService _CurrentConditionsService;

		public CurrentConditionsViewComponent(ICurrentConditionsService currentConditionsService)
		{
			_CurrentConditionsService = currentConditionsService;

		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var saved_location = HttpContext.Request.Cookies["location"];
			var conditions = await _CurrentConditionsService.GetCurrentConditionsAsync(saved_location ?? "");
			return View<WeatherObservation>(conditions?? new WeatherObservation());
		}
	}
}
