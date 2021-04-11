using System;

namespace Itertools
{
    internal static class ApplyFunction
    {
        internal static void EnsurePositive(int repeat)
        {
            if (repeat < 1) throw new ArgumentException("Low", nameof(repeat));
        }

        internal static TResult Apply<T1, T2, TResult>(Func<T1, T2, TResult> valueFactory, Tuple<T1, T2> tuple)
        {
            return valueFactory(tuple.Item1, tuple.Item2);
        }

        internal static TResult Apply<T1, T2, T3, TResult>
        (
            Func<T1, T2, T3, int, TResult> valueFactory,
            Tuple<T1, T2, T3> tuple,
            int index
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3, index);
        }

        internal static TResult Apply<T1, T2, T3, T4, TResult>
        (
            Func<T1, T2, T3, T4, TResult> valueFactory,
            Tuple<T1, T2, T3, T4> tuple
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

        internal static TResult Apply<T1, T2, T3, T4, T5, TResult>
        (
            Func<T1, T2, T3, T4, T5, TResult> valueFactory,
            Tuple<T1, T2, T3, T4, T5> tuple
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

        internal static TResult Apply<T1, T2, T3, T4, T5, T6, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, TResult> valueFactory,
            Tuple<T1, T2, T3, T4, T5, T6> tuple
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        internal static TResult Apply<T1, T2, T3, T4, T5, T6, T7, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> valueFactory,
            Tuple<T1, T2, T3, T4, T5, T6, T7> tuple
        )
        {
            return valueFactory
            (
                tuple.Item1,
                tuple.Item2,
                tuple.Item3,
                tuple.Item4,
                tuple.Item5,
                tuple.Item6,
                tuple.Item7
            );
        }

        #region WITH_INDEX
        internal static TResult Apply<T1, T2, T3, TResult>
        (
            Func<T1, T2, T3, TResult> valueFactory,
            Tuple<T1, T2, T3> tuple
        )
        {
            return valueFactory(tuple.Item1, tuple.Item2, tuple.Item3);
        }
        #endregion
    }
}