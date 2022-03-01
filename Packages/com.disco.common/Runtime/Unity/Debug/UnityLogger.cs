using System.Diagnostics;
using UnityEngine;

namespace Disco.Debug
{
    public static class UnityLogger
    {
        private static readonly string LOG_PROFILER_TAG = "LOG_PROFILER";

        [Conditional("ENABLE_LOG_PROFILER")]
        public static void LOG_PROFILER(string message)
        {
            LOG(LOG_PROFILER_TAG, message);
        }

        [Conditional("ENABLE_LOG_PROFILER")]
        public static void LOG_PROFILER(string message, GameObject gameObject)
        {
            LOG(LOG_PROFILER_TAG, message, gameObject);
        }

        public static void LOG(string tag, string message)
        {
            UnityEngine.Debug.unityLogger.Log(tag, message);
        }

        public static void LOG(string tag, string message, GameObject gameObject)
        {
            UnityEngine.Debug.unityLogger.Log(tag, message + ", ID = " + gameObject.GetInstanceID() + ", Name = " + gameObject.name);
        }
    }
}