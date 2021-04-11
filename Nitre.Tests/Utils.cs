using System;
using System.Collections.Generic;
using System.Linq;

namespace Nitre.Test
{
    internal static class Utils
    {
        internal static IEnumerable<char> RangeOfChars(int count, int start = 65)
        {
            return Enumerable.Range(start, count).Select(Convert.ToChar);
        }
    }
}