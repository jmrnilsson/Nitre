using System;
using System.Collections.Generic;

namespace Itertools
{
    public partial class Itertools
    {
        private static IEnumerable<T> Count<T>(T start, Func<T, T> step) where T : struct
        {
            do { yield return start; start = step(start); } while (true);
        }

        public static IEnumerable<int> Count(int start, int step=1)
        {
            return Count(start, x => x + step);
        }

        public static IEnumerable<float> Count(float start, float step=1f)
        {
            return Count(start, x => x + step);
        }

        public static IEnumerable<double> Count(double start, double step=1d)
        {
            return Count(start, x => x + step);
        }

        public static IEnumerable<decimal> Count(decimal start, decimal step=1.0m)
        {
            return Count(start, x => x + step);
        }

    }
}