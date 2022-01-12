# AccuWeather Web Team Skills Test

This skills test is created by joshua.mellott@accuweather.com and ryan.krinjeck@accuweather.com in order to accurately assess the skill set behind a candidate applying to the AccuWeather web team. We expect this test will take approximately 1 to 2 hours and we hope that you can enjoy the time spent while creating it.

These are very real challenges and data that the web development teams work with and would be similar to what you would be performing alongside the rest of the team here at AccuWeather.

Please do not hesitate to reach out to us with any questions!

## Summary

As AccuWeather, we would like to provide a lightweight web application with key weather information so that users on lower end devices or simply users that don’t engage for long periods of time on the website can be provided with the fastest experience possible with the lowest overhead possible to AccuWeather.

In order to accomplish this, in conversation with a strategic architect the first steps to this are building a page using Asp.NET Core with limited client-side JavaScript, Css, & HTML. We will need to make API calls to the AccuWeather REST API for several different categories that should fill out the needs of the following User Stories.

### User Stories

* As a user, I want to search for my location and view my current weather conditions so I know if I need to wear a jacket going to my car
* As a user, I want to see if there are any severe weather alerts at my grandmother’s house so I can determine whether or not she’s safe to water her roses
* As a user, I want to see the upcoming weather over the next few days so that I can plan a biking trip with my friends
* As a user, I want to see the weather forecast for this evening so that I can plan a nice night out with my significant other

## Technical Requirements

* Asp.NET Core Web App
    * .NET 5 preferred
    * MVC Preferred but any variation acceptable
* AccuWeather REST API Integration
    * API Key: Provided by AccuWeather on request

### API Interface Requirements

* Use a NuGet package for resilience and fault tolerance setup such as [Polly](https://github.com/App-vNext/Polly)
* Create a singleton service and register it through Asp.NET Core’s dependency injection methods so it can be used by your user interface
* Dependency Injection to the Razor
* Data should be pulled exclusively in the backend to make this widget lightweight

### API Documentation

Note: The API Key listed above is only valid for the following APIs

* [Documentation Home](https://developer.accuweather.com/)
* [Location Search API](https://developer.accuweather.com/accuweather-locations-api/apis/get/locations/v1/search)
* [Location Details API](https://developer.accuweather.com/accuweather-locations-api/apis/get/locations/v1/%7BlocationKey%7D)
* [Current Weather Conditions API](https://developer.accuweather.com/accuweather-current-conditions-api/apis/get/currentconditions/v1/%7BlocationKey%7D)
* [Hourly Forecast API](https://developer.accuweather.com/accuweather-forecast-api/apis/get/forecasts/v1/hourly/24hour/%7BlocationKey%7D)
* [Daily Forecast API](https://developer.accuweather.com/accuweather-forecast-api/apis/get/forecasts/v1/daily/5day/%7BlocationKey%7D)
* [Severe Weather Alerts API](https://developer.accuweather.com/accuweather-alerts-api/apis/get/alerts/v1/%7BlocationKey%7D)

## User Interface Requirements

1. Responsive down to 320px and up to 1920px
2. Lightweight JS
3. Lightweight Css
4. Feel free to mirror design concepts from https://www.accuweather.com
5. Modern browser (Safari, Chrome, Firefox) support

### Design Modules

These modules are the UI components that will make up your website or page. You may place all of these components on a single page, or create multiple pages for each module. We strongly suggest using  [Razor View Components](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-5.0) for reusability of your UI components.

* Location Search Module
    * Allow a user to search for their location with the Location Search API
    * This module should drive the location used for all other modules on the page
    * Once selected, it should be obvious to a user which location they are in by using properties from the locations API such as localized name to display the location
    * **Optional.** Store a user’s location in a cookie so that it’s not lost when the page is refreshed
* Current Conditions Module
    * After a user has chosen a location, use that location to pull down current conditions information and display the current temperature & the current ‘status’ denoted by the Phrase in the API response
    * Inject a Weather Icon somewhere in this module
* Hourly Forecast Module
    * Using the same location, display the next twelve hours in a list with the time, temperature, & phrase for each hour
    * Inject a Weather Icon somewhere in this module for each hour
* Daily Forecast Module
    * Similar to the hourly forecast module, display the next five days in a list with the date, temperature minimum and maximums for that day, and include a way to display a phrase from the day and night properties
    * Inject a Weather Icon somewhere next to the appropriate day & night phrase
* Alerts Module
    * If a weather alert is active for a location, display a warning to the user in a UI module on-page so that they are quickly and effectively alerted to any alerts active for their area
    * You may assume there is always an alert area in the list and use the first one
* Weather Icon Module
    * For the Current Conditions as well as the Hourly & Daily Forecast modules, there is an associated Icon, or IconCode property that aligns with a numbered icon in the icon set found below
    * You can use the www.accuweather.com icons for this
    * If possible, use a [Tag Helper](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/authoring?view=aspnetcore-5.0) for this

## Delivery Requirements

All source code and project files should be made accessible either through a public Git repository. The application should be self-contained and able to be executed by pulling down the source code, building, and executing through the dotnet SDK.

Provide a link to the public Git repository and any non-documented runtime instructions to ryan.krinjeck@accuweather.com and joshua.mellott@accuweather.com.
