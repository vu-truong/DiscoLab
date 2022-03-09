using System.Diagnostics;
using UnityEngine;

namespace Disco
{
    public static partial class DiscoLogger
    {
        private const string DISCO_LOGGER = "DISCO_LOGGER";
        private const string DISCO_LOGGER_PROFILER = "DISCO_LOGGER_PROFILER";

        [Conditional(DISCO_LOGGER_PROFILER)]
        public static void LOG_PROFILER(string message)
        {
            LOG(DISCO_LOGGER_PROFILER, message);
        }

        [Conditional(DISCO_LOGGER_PROFILER)]
        public static void LOG_PROFILER(string message, GameObject gameObject)
        {
            LOG(DISCO_LOGGER_PROFILER, message, gameObject);
        }

        [Conditional(DISCO_LOGGER)]
        public static void LOG(string message)
        {
            LOG(DISCO_LOGGER, message);
        }

        [Conditional(DISCO_LOGGER)]
        public static void LOG(string message, GameObject gameObject)
        {
            LOG(DISCO_LOGGER, message, gameObject);
        }

        [Conditional(DISCO_LOGGER)]
        public static void LOG(string tag, string message)
        {
            UnityEngine.Debug.unityLogger.Log(tag, message);
        }

        [Conditional(DISCO_LOGGER)]
        public static void LOG(string tag, string message, GameObject gameObject)
        {
            UnityEngine.Debug.unityLogger.Log(tag, message + ", InstanceID = " + gameObject.GetInstanceID() + ", Name = " + gameObject.name);
        }
    }
}