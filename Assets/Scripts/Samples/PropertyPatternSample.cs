using UnityCSharpAwesomeSyntax.Types;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class PropertyPatternSample : ISample
    {
        private static string Announce(WeatherInfo info) => info switch
        {
            { WeatherType: WeatherType.Rainy, Temperature: > 25 } => "too hot and rainy!",
            { Temperature: > 40, WeatherType: WeatherType.Sunny, ChanceOfRain: < 5 } => "it must be desert",
            { Temperature: > 50 or < -30 } => "Invalid Weather!",
            _ => info.WeatherType.ToString()
        };

        public void Run()
        {
            var weather = new WeatherInfo
            {
                WeatherType = WeatherType.Sunny,
                ChanceOfRain = 0,
                Temperature = 45,
            };

            var invalid = new WeatherInfo
            {
                WeatherType = WeatherType.Cloudy,
                Temperature = 100,
                ChanceOfRain = 50
            };

            Debug.Log(Announce(weather));
        }
    }
}