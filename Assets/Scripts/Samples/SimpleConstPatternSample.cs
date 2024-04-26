using UnityCSharpAwesomeSyntax.Types;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class SimpleConstPatternSample : ISample
    {
        private static bool TryParseWeather(string weatherString, out WeatherType result)
        {
            switch (weatherString)
            {
                case "Sunny":
                    result = WeatherType.Sunny;
                    return true;
                case "Cloudy":
                    result = WeatherType.Cloudy;
                    return true;
                case "Rainy":
                    result = WeatherType.Rainy;
                    return true;
                default:
                    result = WeatherType.Unknown;
                    return false;
            }
        }

        private static bool TryParseWeatherV2(string weatherString, out WeatherType result)
        {
            result = weatherString switch
            {
                "Sunny" => WeatherType.Sunny,
                "Cloudy" => WeatherType.Cloudy,
                "Rainy" => WeatherType.Rainy,
                _ => WeatherType.Unknown
            };
            return result != WeatherType.Unknown;
        }

        public void Run()
        {
            const string weatherStr = "Cloudy";

            if (TryParseWeatherV2(weatherStr, out var weather))
            {
                Debug.Log($"success, weather is {weather}");
            }
            else
            {
                Debug.LogError("parse failed!");
            }
        }
    }
}