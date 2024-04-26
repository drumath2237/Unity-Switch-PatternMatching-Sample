using UnityCSharpAwesomeSyntax.Types;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class TupplePatternSample : ISample
    {
        private static string Announce(WeatherInfo info) => info switch
        {
            (0, _) => "just 0",
            (> 25, < 5) => "you should drink water",
            _ => "..."
        };

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}