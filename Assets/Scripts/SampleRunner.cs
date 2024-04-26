using UnityCSharpAwesomeSyntax.Samples;
using UnityEngine;

namespace UnityCSharpAwesomeSyntax
{
    public interface ISample
    {
        void Run();
    }

    public class SampleRunner : MonoBehaviour
    {
        private void Start()
        {
            ISample sample = new SimpleConstPatternSample();
            sample.Run();
        }
    }
}