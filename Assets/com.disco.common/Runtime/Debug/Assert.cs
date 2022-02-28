
using System.Diagnostics;

namespace Disco.Debug
{
    public static class Assert
    {
        [Conditional("ENABLE_ASSERT")]
        public static void AreEqual<T>(T expected, T actual)
        {
            UnityEngine.Assertions.Assert.AreEqual(expected, actual);
        }

        [Conditional("ENABLE_ASSERT")]
        public static void AreNotEqual<T>(T expected, T actual)
        {
            UnityEngine.Assertions.Assert.AreNotEqual(expected, actual);
        }

        [Conditional("ENABLE_ASSERT")]
        public static void IsNull<T>(T value) where T : class
        {
            UnityEngine.Assertions.Assert.IsNull(value);
        }

        [Conditional("ENABLE_ASSERT")]
        public static void IsNotNull<T>(T value) where T : class
        {
            UnityEngine.Assertions.Assert.IsNotNull(value);
        }

        [Conditional("ENABLE_ASSERT")]
        public static void IsNotNull(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                UnityEngine.Assertions.Assert.IsNotNull(values[i]);
            }
        }
    }
}


