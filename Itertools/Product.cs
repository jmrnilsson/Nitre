using System;
using System.Collections.Generic;
using System.Linq;

namespace Itertools
{
    public partial class Itertools
    {
        private static void EnsurePositive(int repeat)
        {
            if (repeat < 1) throw new ArgumentException("Too low", nameof(repeat));
        }

        public static IEnumerable<Tuple<T1, T2>> Product<T1, T2>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from e0 in iterable0
                from e1 in iterable1
                select new Tuple<T1, T2>(e0, e1);
        }

        public static IEnumerable<Tuple<T1, T2, T3>> Product<T1, T2, T3>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from i0 in iterable0
                from i1 in iterable1
                from i2 in iterable2
                select new Tuple<T1, T2, T3>(i0, i1, i2);
        }

        public static IEnumerable<Tuple<T1, T2, T3, T4>> Product<T1, T2, T3, T4>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            IEnumerable<T4> iterable3,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from i0 in iterable0
                from i1 in iterable1
                from i2 in iterable2
                from i3 in iterable3
                select new Tuple<T1, T2, T3, T4>(i0, i1, i2, i3);
        }


        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> Product<T1, T2, T3, T4, T5>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            IEnumerable<T4> iterable3,
            IEnumerable<T5> iterable4,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from i0 in iterable0
                from i1 in iterable1
                from i2 in iterable2
                from i3 in iterable3
                from i4 in iterable4
                select new Tuple<T1, T2, T3, T4, T5>(i0, i1, i2, i3, i4);
        }


        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Product<T1, T2, T3, T4, T5, T6>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            IEnumerable<T4> iterable3,
            IEnumerable<T5> iterable4,
            IEnumerable<T6> iterable5,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from i0 in iterable0
                from i1 in iterable1
                from i2 in iterable2
                from i3 in iterable3
                from i4 in iterable4
                from i5 in iterable5
                select new Tuple<T1, T2, T3, T4, T5, T6>(i0, i1, i2, i3, i4, i5);
        }

        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Product<T1, T2, T3, T4, T5, T6, T7>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            IEnumerable<T4> iterable3,
            IEnumerable<T5> iterable4,
            IEnumerable<T6> iterable5,
            IEnumerable<T7> iterable6,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            return
                from repetitions in Enumerable.Range(0, repeat)
                from i0 in iterable0
                from i1 in iterable1
                from i2 in iterable2
                from i3 in iterable3
                from i4 in iterable4
                from i5 in iterable5
                from i6 in iterable6
                select new Tuple<T1, T2, T3, T4, T5, T6, T7>(i0, i1, i2, i3, i4, i5, i6);
        }


        /*
        count             X
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
        product        X
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