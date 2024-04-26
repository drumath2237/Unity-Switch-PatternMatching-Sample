namespace UnityCSharpAwesomeSyntax.Types
{
    public enum WeatherType
    {
        Unknown,
        Sunny,
        Cloudy,
        Rainy,
    }

    public class WeatherInfo
    {
        public WeatherType WeatherType;
        public float Temperature;
        public float ChanceOfRain;

        public void Deconstruct(out float temperature, out float chanceOfRain)
        {
            temperature = Temperature;
            chanceOfRain = ChanceOfRain;
        }
    }

    public class WeatherWithWindInfo : WeatherInfo
    {
        public float WindSpeed;
    }

    public class WeatherWithLocale : WeatherInfo
    {
        public string Locale;
    }

    public static class WeatherInfoExtension
    {
    }
}