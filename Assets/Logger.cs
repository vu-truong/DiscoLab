
using System.Diagnostics;
using UnityEngine;

namespace Disco
{
    public static class Logger
    {
        private static readonly string LOG_DI_TAG = "LOG_DI";

        [Conditional("ENABLE_LOG_DI")]
        public static void LOG_DI(string message)
        {
            Disco.Debug.UnityLogger.LOG(LOG_DI_TAG, message);
        }

        [Conditional("ENABLE_LOG_DI")]
        public static void LOG_DI(string message, GameObject gameObject)
        {
            Disco.Debug.UnityLogger.LOG(LOG_DI_TAG, message, gameObject);
        }
    }
}

