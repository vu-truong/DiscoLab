
using UnityEngine;
using Disco;

public class GameObjectTest : MonoBehaviour
{
    public MeshRenderer _renderer;
    void Start()
    {
        //this.SetEnabled_AllChildren
        _renderer.SetActive(false);
        Disco.DiscoLogger.LOG_PROFILER("tEST");
    }
}
