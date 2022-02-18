using AccuWeather.Web.SkillsTest.Services.Api.Alerts;
using AccuWeather.Web.SkillsTest.Services.Api.Core;
using AccuWeather.Web.SkillsTest.Services.Api.CurrentConditions;
using AccuWeather.Web.SkillsTest.Services.Api.Forecasts;
using AccuWeather.Web.SkillsTest.Services.Api.Locations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddSingleton<IAccuWeatherApiService, AccuWeatherApiService>();
builder.Services.AddSingleton<ILocationService, LocationService>();
builder.Services.AddSingleton<IAlertsService, AlertsService>();
builder.Services.AddSingleton<ICurrentConditionsService, CurrentConditionsService>();
builder.Services.AddSingleton<IForecastService, ForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
