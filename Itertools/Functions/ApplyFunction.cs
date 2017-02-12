﻿using System;

namespace Itertools.Functions
{
    public static class ApplyFunction
    {
        public static TResult Apply<T1, T2, TResult>(Func<T1, T2, TResult> valueFactory, Tuple<T1, T2> tuple)
        {
            return valueFactory(tuple.Item1, tuple.Item2);
        }

        public static TResult Apply<T1, T2, T3, TResult>
        (
            Func<T1, T2, T3, TResult> valueFactory,
            Tuple<T1, T2, T3> tuple
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3);
        }
    }
}