
using System;
using System.Diagnostics;

namespace Disco
{
    public static partial class DiscoAssert
    {
        private const string DISCO_ASSERTIONS = "DISCO_ASSERTIONS";

        [Conditional(DISCO_ASSERTIONS)]
        public static void AreEqual<T>(T expected, T actual)
        {
            UnityEngine.Assertions.Assert.AreEqual(expected, actual);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void AreNotEqual<T>(T expected, T actual)
        {
            UnityEngine.Assertions.Assert.AreNotEqual(expected, actual);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void IsNull<T>(T value) where T : class
        {
            UnityEngine.Assertions.Assert.IsNull(value);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void IsNotNull<T>(T value) where T : class
        {
            UnityEngine.Assertions.Assert.IsNotNull(value);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void IsNotNull(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                UnityEngine.Assertions.Assert.IsNotNull(values[i]);
            }
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void Greater<T>(T a, T b) where T : IComparable
        {
            bool result = a.CompareTo(b) > 0;
            string message = $@"Assertion failure. a <= b: (a = {a}, b = {b})
                                Expected: a > b";
            UnityEngine.Assertions.Assert.IsTrue(result, message);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void GreaterOrEqual<T>(T a, T b) where T : IComparable
        {
            bool result = a.CompareTo(b) >= 0;
            string message = $@"Assertion failure. a < b: (a = {a}, b = {b})
                                Expected: a >= b";
            UnityEngine.Assertions.Assert.IsTrue(result, message);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void Less<T>(T a, T b) where T : IComparable
        {
            bool result = a.CompareTo(b) < 0;
            string message = $@"Assertion failure. a >= b: (a = {a}, b = {b})
                                Expected: a < b";
            UnityEngine.Assertions.Assert.IsTrue(result, message);
        }

        [Conditional(DISCO_ASSERTIONS)]
        public static void LessOrEqual<T>(T a, T b) where T : IComparable
        {
            bool result = a.CompareTo(b) <= 0;
            string message = $@"Assertion failure. a > b: (a = {a}, b = {b})
                                Expected: a <= b";
            UnityEngine.Assertions.Assert.IsTrue(result, message);
        }
    }
}


