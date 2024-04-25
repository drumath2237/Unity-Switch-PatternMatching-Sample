using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax.Samples
{
    public class SwitchAndPatternMatchingSample : ISample
    {
        public Task RunAsync(CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return Task.CompletedTask;
            }

            Debug.Log("Hello");
            return Task.CompletedTask;
        }
    }
}