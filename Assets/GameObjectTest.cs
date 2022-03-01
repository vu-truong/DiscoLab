
using UnityEngine;
using Disco;

public class GameObjectTest : MonoBehaviour
{
    public MeshRenderer _renderer;
    void Start()
    {
        _renderer.SetActive(false);
        StandardLogger.LOG_PROFILER("tEST");
    }
}
