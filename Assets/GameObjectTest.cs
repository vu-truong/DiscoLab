
using UnityEngine;
using Disco.Extensions;
using Disco;
using Disco.Profiling;

public class GameObjectTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.EnableAllRenderers(false);
        using (var profiler = new StandardProfiler("Profiler Test"))
        {
            using (profiler.Sample("Sample Test"))
            {

            }
        }
    }
}
