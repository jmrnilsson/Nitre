using System;
using System.Collections.Generic;
using System.Linq;

namespace Itertools
{
    public partial class Itertools
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
    }
}
