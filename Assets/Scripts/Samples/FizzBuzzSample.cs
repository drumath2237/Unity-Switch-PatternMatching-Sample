using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class FizzBuzzSample : ISample
    {
        public Task RunAsync(CancellationToken token)
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

            return Task.CompletedTask;
        }
    }
}