using System;
using System.Collections.Generic;
using System.Linq;
using static Nitre.ApplyFunction;

namespace Nitre.Functions
{
    public static class ProductFunction
    {
        #region ProducrEnumerable
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
        #endregion

        #region ProductTuple
        // Looks like there should be some unzip version around..

        public static Tuple<IEnumerable<T1>, IEnumerable<T2>> Product<T1, T2>
        (
            IEnumerable<Tuple<T1, T2>> iterable,
            int repeat=1
        )
        {
            EnsurePositive(repeat);
            var iterableList = iterable.ToList();
            var iterable0 = new T1[iterableList.Count];
            var iterable1 = new T2[iterableList.Count];

            for (var i = 0; i < iterableList.Count; i++)
            {
                iterable0[i] = iterableList[i].Item1;
                iterable1[i] = iterableList[i].Item2;
            }
            return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(iterable0, iterable1);
        }

        #endregion
    }
}
