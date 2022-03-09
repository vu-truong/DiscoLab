
using Disco;
using System.Diagnostics;
using UnityEngine;

public static class GameLogger
{
    private static readonly string LOG_DI_TAG = "LOG_DI";

    [Conditional("ENABLE_LOG_DI")]
    public static void LOG_DI(string message)
    {
        Disco.DiscoLogger.LOG(LOG_DI_TAG, message);
    }

    [Conditional("ENABLE_LOG_DI")]
    public static void LOG_DI(string message, GameObject gameObject)
    {
        Disco.DiscoLogger.LOG(LOG_DI_TAG, message, gameObject);
    }
}

