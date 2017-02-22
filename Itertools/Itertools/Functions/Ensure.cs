using System;

namespace Itertools.Functions
{
    internal class Ensure
    {
        internal static void Positive(int repeat)
        {
            if (repeat < 1) throw new ArgumentException("Too low", nameof(repeat));
        }
    }
}