
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Assertions;

public class AssertionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Assert.raiseExceptions = false;
        AssertTest(null);
        TraceTest(null);

        GreaterTest(50, 70);
    }

    void AssertTest(object obj)
    {
        Assert.IsNotNull(obj);
        UnityEngine.Debug.Log("AssertTest");
    }

    void ExceptionTest(object obj)
    {
        if (obj == null)
            throw new NullReferenceException();

        UnityEngine.Debug.Log("ExceptionTest");
    }

    void TraceTest(object obj)
    {
        UnityEngine.Debug.Assert(obj != null, "Failed");
        UnityEngine.Debug.Log("TraceTest");
    }

    void GreaterTest(int a, int b)
    {
        Disco.DiscoAssert.Greater(a, b);
    }
}
