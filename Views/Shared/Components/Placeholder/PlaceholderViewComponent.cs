using Microsoft.AspNetCore.Mvc;

namespace AccuWeather.Web.SkillsTest.Views.Shared.Components.Placeholder
{
	public class PlaceholderViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(string text)
		{
			return View<string>(text);
		}
	}
}
