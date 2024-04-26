using UnityCSharpAwesomeSyntax.Types;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class TypePatternSample : ISample
    {
        private static string WeatherAnnouncer(WeatherInfo weatherInfo) => weatherInfo switch
        {
            WeatherWithWindInfo withWind => $"wind speed is {withWind.WindSpeed}m/s",
            WeatherWithLocale withLocale => $"{withLocale.Locale}'s weather is {withLocale.WeatherType}",
            _ => $"today is {weatherInfo.WeatherType}"
        };

        public void Run()
        {
            var weatherWithWind = new WeatherWithWindInfo
            {
                WeatherType = WeatherType.Cloudy,
                Temperature = 15,
                WindSpeed = 5,
                ChanceOfRain = 75
            };

            var weatherWithLocale = new WeatherWithLocale
            {
                WeatherType = WeatherType.Sunny,
                Temperature = 21,
                ChanceOfRain = 5,
                Locale = "Tokyo"
            };

            var announcement = WeatherAnnouncer(weatherWithWind);
            Debug.Log(announcement);
        }
    }
}