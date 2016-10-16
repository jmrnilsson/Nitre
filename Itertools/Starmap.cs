using System;
using System.Collections.Generic;
using System.Linq;

namespace Itertools
{
    public partial class Itertools
    {
        public static IEnumerable<TResult> Starmap<T, TResult>(Func<T, TResult> valueFactory, IEnumerable<T> iterable)
        {
            return iterable.Select(valueFactory);
        }
        public static IEnumerable<TResult> Starmap<T, TResult>(Func<T, TResult> valueFactory, IEnumerable<IEnumerable<T>> iterables)
        {
            return iterables.SelectMany(s => s.Select(valueFactory));
        }

/*
        public static IEnumerable<TResult> Starmap(Func<Tuple<T>, TResult> valueFactory, IEnumerable<Tuple<T>> iterable)
        {
            return iterable.Select(valueFactory);
        }
*/

    }
}