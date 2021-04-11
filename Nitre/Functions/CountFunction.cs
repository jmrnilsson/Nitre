using System;
using System.Collections.Generic;

namespace Itertools.Functions
{
    internal static class CountFunction
    {
        internal static IEnumerable<T> Count<T>(T start, Func<T, T> step) where T : struct
        {
            do { yield return start; start = step(start); } while (true);
        }
    }
}