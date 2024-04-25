using System.Linq;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class FizzBuzzSample : ISample
    {
        public void Run()
        {
            var fizzbuzz = Enumerable.Range(0, 30)
                .Select(x => x switch
                {
                    _ when x % 15 == 0 => "FizzBuzz",
                    _ when x % 3 == 0 => "Fizz",
                    _ when x % 5 == 0 => "Buzz",
                    _ => x.ToString()
                })
                .Aggregate((a, b) => a + "\n" + b);

            Debug.Log(fizzbuzz);
        }
    }
}