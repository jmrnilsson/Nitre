using System;
using System.Collections.Generic;
using System.Linq;
using static Itertools.ApplyFunction;

namespace Itertools.Functions
{
    public static class FilterFunction
    {
        public static IEnumerable<Tuple<T1, T2, T3>> Filter<T1, T2, T3>
        (
            Func<T1, T2, T3, bool> valueFactory,
            IEnumerable<Tuple<T1, T2, T3>> iterable
        )
        {
            return iterable.Where(t => Apply(valueFactory, t));
        }

        public static IEnumerable<Tuple<T1, T2, T3>> Filter<T1, T2, T3>
        (
            Func<T1, T2, T3, int, bool> valueFactory,
            IEnumerable<Tuple<T1, T2, T3>> iterable
        )
        {
            return iterable.Where((t, i) => Apply(valueFactory, t, i));
        }

    }
}
