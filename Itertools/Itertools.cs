using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Itertools
{
    public class Itertools
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

        public static IEnumerable<Tuple<T1, T2>> Product<T1, T2>
        (
            IEnumerable<T1> first,
            IEnumerable<T2> second,
            int repeat=1
        )
        {
            if (repeat < 1) throw new ArgumentException();
            return
                from repetitions in Enumerable.Range(0, repeat)
                from e0 in first
                from e1 in second
                select new Tuple<T1, T2>(e0, e1);
        }

        /*
        count
        cycle
        repeat
        chain
        compress
        dropwhile
        groupby
        filter
        filterfalse
        slice
        map
        starmap
        tee
        takewhile
        product
        permutations
        combinations
        combinations_with_replacements

        IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(IEnumerable<T1> first, IEnumerable<T2> second);

        IEnumerable<Tuple<T1, T2>> ZipLongest<T1, T2>
        (
            IEnumerable<T1> first, IEnumerable<T2> second, T2 fillValue=default(T2)
        );

        float Count(float start, float step=1f);
        double Count(double start, double step=1d);
        decimal Count(decimal start, decimal step=1.0m);
        int Count(int start, int step=1);
        // ReSharper disable once BuiltInTypeReferenceStyle
        Int16 Count(Int16 start, Int16 step = 1);
        // ReSharper disable once BuiltInTypeReferenceStyle
        Int64 Count(Int64 start, Int64 step = 1);
        */

    }
}