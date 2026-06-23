using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace GarbageCollection.MemoryPressure
{
    public static class MathCache
    {
        private static readonly Dictionary<string, object> Cache = new();

        public static T Add<T>(T left, T right)
            where T : INumber<T>
        {
            return Execute(left, right, "+", (a, b) => a + b);
        }

        public static T Subtract<T>(T left, T right)
            where T : INumber<T>
        {
            return Execute(left, right, "-", (a, b) => a - b);
        }

        public static T Multiply<T>(T left, T right)
            where T : INumber<T>
        {
            return Execute(left, right, "*", (a, b) => a * b);
        }

        public static T Divide<T>(T left, T right)
            where T : INumber<T>
        {
            return Execute(left, right, "/", (a, b) => a / b);
        }

        private static T Execute<T>(
            T left,
            T right,
            string operation,
            Func<T, T, T> calculation)
            where T : INumber<T>
        {
            string key =
                $"{typeof(T).FullName}|{operation}|{left}|{right}";

            if (Cache.TryGetValue(key, out object? cached))
            {
                Console.WriteLine($"CACHE HIT : {key}");
                return (T)cached;
            }

            T result = calculation(left, right);

            Cache[key] = result;

            Console.WriteLine($"CALCULATED : {key}");

            return result;
        }

        public static int CachedCount => Cache.Count;
    }
}
