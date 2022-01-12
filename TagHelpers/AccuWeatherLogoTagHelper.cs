using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AccuWeather.Web.SkillsTest.TagHelpers
{
	[HtmlTargetElement("accuweather-logo", TagStructure = TagStructure.NormalOrSelfClosing)]
	public class AccuWeatherLogoTagHelper : TagHelper
	{
		public int? Width { get; set; }

		public int? Height { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagMode = TagMode.StartTagAndEndTag;
			output.TagName = "svg";
			output.AddClass("accuweather-logo", HtmlEncoder.Default);
			output.Attributes.SetAttribute("xmlns", "http://www.w3.org/2000/svg");
			if (Width.HasValue) output.Attributes.SetAttribute("width", Width);
			if (Height.HasValue) output.Attributes.SetAttribute("height", Height);
			output.Attributes.SetAttribute("viewBox", "0 0 404 58");
			output.Content.SetHtmlContent("<g fill=\"none\" fill-rule=\"nonzero\"><path fill=\"#000\" d=\"M393.236 48.846V34.1c0-3.005.63-5.031 1.887-6.08 1.258-1.048 3.355-1.537 6.151-1.537H404v-6.638h-2.307c-2.096 0-3.914.28-5.382.908-1.537.63-2.656 1.538-3.564 2.656l-1.398-3.564h-5.242v29h7.129zm-25.302-23.62c2.027 0 3.564.56 4.613 1.747 1.048 1.188 1.607 2.726 1.747 4.613h-13.14c.14-1.957.699-3.494 1.747-4.613 1.048-1.187 2.586-1.746 4.613-1.746h.42zm5.94 14.885c-.489 1.048-1.187 1.887-2.096 2.446-.909.629-2.027.908-3.495.908h-.49c-2.166 0-3.774-.629-4.892-1.817-1.118-1.188-1.747-2.795-1.887-4.682h20.34v-2.935c0-4.542-1.189-8.176-3.565-10.831-2.377-2.725-5.662-4.053-9.786-4.053h-.489c-4.124 0-7.409 1.328-9.855 4.053-2.447 2.655-3.635 6.15-3.635 10.412v1.887c0 2.096.35 3.983.979 5.73.629 1.747 1.537 3.214 2.726 4.472 1.188 1.258 2.656 2.236 4.333 2.935 1.748.699 3.635 1.048 5.802 1.048h.489c2.726 0 5.032-.559 6.99-1.607 1.957-1.048 3.564-2.655 4.753-4.822l-6.221-3.144zm-43.545 8.735V31.935c.07-1.957.56-3.564 1.538-4.822.979-1.258 2.446-1.886 4.264-1.886h.699c1.607 0 2.866.489 3.774 1.537.979.978 1.398 2.655 1.398 4.961v17.19h7.13V30.468c0-3.424-.91-6.149-2.796-8.245-1.888-2.097-4.334-3.145-7.48-3.145h-.838c-1.538 0-3.006.28-4.334.909-1.328.628-2.516 1.467-3.494 2.515V8.246h-7.13v40.6h7.27zm-18.662-6.36c-.49-.419-.699-1.187-.699-2.305V25.576h6.99v-5.73h-6.99v-6.36h-6.08l-.77 6.36h-4.753v5.73h4.544V40.25c0 2.655.629 4.751 1.887 6.289 1.258 1.537 3.425 2.306 6.43 2.306h5.662v-5.73h-4.124c-.979 0-1.677-.21-2.097-.63zm-29.706 1.119c-1.468 0-2.586-.28-3.355-.839-.769-.559-1.188-1.397-1.188-2.446v-.21c0-1.047.42-1.956 1.328-2.655.839-.698 2.376-1.048 4.613-1.048h5.312v1.048c0 2.097-.559 3.634-1.677 4.612-1.119.979-2.656 1.538-4.474 1.538h-.559zm-1.398 6.01c1.888 0 3.495-.35 4.963-1.049s2.656-1.747 3.635-3.214l1.188 3.564h5.382V29.908c0-3.563-1.049-6.289-3.146-8.106-2.096-1.816-5.032-2.725-8.737-2.725h-.699c-3.355 0-6.01.699-7.968 2.027-1.957 1.397-3.215 3.074-3.774 5.03l6.29 2.586c.35-.978.98-1.747 1.818-2.445.839-.63 2.027-.979 3.495-.979h.699c1.677 0 2.935.42 3.704 1.188.839.839 1.188 1.957 1.188 3.424v1.468h-5.172c-4.264 0-7.479.838-9.716 2.516-2.236 1.677-3.355 3.913-3.355 6.638v.42c0 2.725.84 4.821 2.517 6.428 1.677 1.538 4.054 2.376 7.13 2.376h.558v-.14zm-26.84-24.388c2.027 0 3.565.559 4.613 1.746 1.049 1.188 1.608 2.726 1.748 4.613h-13.14c.139-1.957.698-3.494 1.747-4.613 1.048-1.187 2.586-1.746 4.613-1.746h.42zm5.941 14.884c-.489 1.048-1.188 1.887-2.097 2.446-.908.629-2.027.908-3.494.908h-.49c-2.166 0-3.774-.629-4.892-1.817-1.119-1.188-1.748-2.795-1.888-4.682h20.34v-2.935c0-4.542-1.188-8.176-3.564-10.831-2.377-2.725-5.662-4.053-9.786-4.053h-.56c-4.123 0-7.408 1.328-9.854 4.053-2.447 2.655-3.635 6.15-3.635 10.412v1.887c0 2.096.35 3.983.978 5.73.63 1.747 1.538 3.214 2.726 4.472 1.189 1.258 2.656 2.236 4.334 2.935 1.747.699 3.635 1.048 5.801 1.048h.49c2.726 0 5.032-.559 6.99-1.607 1.956-1.048 3.564-2.655 4.752-4.822l-6.15-3.144zm-53.96 8.735l8.528-29.56 8.108 29.56h6.5l11.673-40.111v-.49h-6.99l-7.688 28.721-7.55-28.72h-7.688l-7.898 29.21-7.479-29.21h-7.339v.489l11.183 40.11h6.64zm-45.782-29v18.378c0 3.424.91 6.15 2.796 8.246 1.888 2.096 4.334 3.144 7.48 3.144h.768c1.747 0 3.355-.349 4.753-1.048 1.468-.699 2.656-1.747 3.635-3.074l1.188 3.354h5.312v-29h-7.06v16.91c-.07 1.957-.559 3.564-1.607 4.822-1.049 1.258-2.447 1.887-4.334 1.887h-.699c-1.537 0-2.796-.49-3.774-1.537-.979-.979-1.468-2.656-1.468-4.962v-17.19h-6.99v.07zm-7.828 1.188c-1.957-1.258-4.473-1.887-7.619-1.887h-.489c-4.124 0-7.409 1.188-9.855 3.634-2.447 2.446-3.635 5.66-3.635 9.713v3.704c0 4.053 1.188 7.337 3.635 9.713 2.446 2.446 5.661 3.634 9.855 3.634h.49c2.865 0 5.242-.56 7.129-1.678 1.887-1.118 3.355-2.725 4.473-4.961l-5.871-3.284c-.49 1.118-1.188 2.026-2.097 2.725-.909.699-2.097 1.048-3.635 1.048h-.489c-2.237 0-3.844-.699-4.893-2.026-1.048-1.328-1.537-3.075-1.537-5.241v-3.564c0-2.166.489-3.913 1.537-5.241 1.049-1.328 2.656-2.027 4.893-2.027h.49c1.537 0 2.795.35 3.704 1.049.909.698 1.608 1.677 2.097 2.865l6.15-2.935c-.908-2.167-2.376-3.983-4.333-5.241zm-28.587 0c-1.958-1.258-4.474-1.887-7.62-1.887h-.488c-4.124 0-7.41 1.188-9.856 3.634-2.446 2.446-3.634 5.66-3.634 9.713v3.704c0 4.053 1.188 7.337 3.634 9.713 2.447 2.446 5.662 3.634 9.856 3.634h.489c2.866 0 5.242-.56 7.13-1.678 1.886-1.118 3.354-2.725 4.473-4.961l-5.872-3.284c-.489 1.118-1.188 2.026-2.097 2.725-.908.699-2.096 1.048-3.634 1.048h-.49c-2.236 0-3.844-.699-4.892-2.026-1.049-1.328-1.538-3.075-1.538-5.241v-3.564c0-2.166.49-3.913 1.538-5.241 1.048-1.328 2.656-2.027 4.893-2.027h.489c1.538 0 2.796.35 3.704 1.049.909.698 1.608 1.677 2.097 2.865l6.151-2.935c-.978-2.167-2.376-3.983-4.333-5.241zm-40.68-2.167l4.823 14.955h-9.716l4.893-14.955zM79.402 8.246l-13.49 40.11v.49h7.06l2.795-8.456h14.05l2.726 8.456h7.409v-.49l-13.49-40.11h-7.06z\"/><path fill=\"#F05514\" d=\"M28.867 48.916c-11.043 0-20.06-9.015-20.06-20.056 0-11.04 9.017-19.985 20.06-19.985 11.044 0 19.99 9.014 19.99 19.985 0 11.111-8.946 20.056-19.99 20.056zM57.734 28.79l-6.57-5.94 2.656-8.455-8.667-1.887-1.887-8.665-8.458 2.726L28.798 0l-5.942 6.569L14.4 3.913l-1.888 8.665-8.667 1.887L6.57 22.92 0 28.93l6.57 5.94-2.656 8.455 8.667 1.887 1.888 8.665 8.457-2.725 6.011 6.568 5.941-6.568 8.458 2.655 1.887-8.665 8.667-1.956-2.726-8.456 6.57-5.94z\"/><path fill=\"#F05514\" d=\"M16.216 16.282c6.99-6.988 18.313-6.988 25.302 0 6.99 6.988 6.99 18.308 0 25.296-6.99 6.988-18.312 6.988-25.302 0-6.99-6.988-6.99-18.378 0-25.296\"/></g>");
		}
	}
}