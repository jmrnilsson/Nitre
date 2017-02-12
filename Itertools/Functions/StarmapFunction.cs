﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Itertools.Functions
{
    public static class StarmapFunction
    {
        public static IEnumerable<TResult> Starmap<T1, T2, TResult>
        (
            Func<T1, T2, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2));
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, TResult>
        (
            Func<T1, T2, T3, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2, t.Item3));
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, TResult>
        (
            Func<T1, T2, T3, T4, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2, t.Item3, t.Item4));
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, TResult>
        (
            Func<T1, T2, T3, T4, T5, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5));
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, T6, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6));
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, T6, T7, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> iterable
        )
        {
            return iterable.Select(t => valueFactory(t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7));
        }
    }
}
