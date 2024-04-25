using System;
using System.Threading;
using System.Threading.Tasks;
using UnityCSharpAwesomeSyntax.Samples;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax
{
    public interface ISample
    {
        Task RunAsync(CancellationToken token);
    }

    public class SampleRunner : MonoBehaviour
    {
        private CancellationTokenSource _tokenSource;

        private async Task Start()
        {
            _tokenSource = new CancellationTokenSource();

            ISample sample = new SwitchAndPatternMatchingSample();

            await sample.RunAsync(_tokenSource.Token);
        }

        private void OnDestroy()
        {
            _tokenSource.Cancel();
            _tokenSource.Dispose();
        }
    }
}