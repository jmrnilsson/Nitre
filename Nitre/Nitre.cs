using System;
using System.Collections.Generic;
using System.Linq;
using Nitre.Functions;

namespace Nitre
{
    public static class Nitre
    {
        #region 1_COUNT
        public static IEnumerable<int> Count(int start, int step=1)
        {
            return CountFunction.Count(start, x => x + step);
        }

        public static IEnumerable<float> Count(float start, float step=1f)
        {
            return CountFunction.Count(start, x => x + step);
        }

        public static IEnumerable<double> Count(double start, double step=1d)
        {
            return CountFunction.Count(start, x => x + step);
        }

        public static IEnumerable<decimal> Count(decimal start, decimal step=1.0m)
        {
            return CountFunction.Count(start, x => x + step);
        }
		#endregion

		#region 6_DROPWHILE
		public static IEnumerable<TSource> DropWhile<TSource>
		(
			this IEnumerable<TSource> source,
			Func<TSource, int, bool> predicate
		)
		{
			return source.SkipWhile(predicate);
		}

		public static IEnumerable<TSource> DropWhile<TSource>
		(
			this IEnumerable<TSource> source,
			Func<TSource, bool> predicate
		)
		{
			return source.SkipWhile(predicate);
		}
		#endregion

		#region 8_FILTER
		public static IEnumerable<TSource> Filter<TSource>
		(
			this IEnumerable<TSource> source,
			Func<TSource, int, bool> predicate
		)
		{
			return source.Where((it, i) => predicate(it, i));
		}

		public static IEnumerable<TSource> Filter<TSource>
		(
			this IEnumerable<TSource> source,
			Func<TSource, bool> predicate
		)
		{
			return source.Where(it => predicate(it));
		}
        #endregion

        #region 9_FILTERFALSE
        public static IEnumerable<TSource> FilterFalse<TSource>
        (
			this IEnumerable<TSource> source,
            Func<TSource, int, bool> predicate
        )
        {
            return source.Where((it, i) => !predicate(it, i));
        }

        public static IEnumerable<TSource> FilterFalse<TSource>
        (
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate
        )
        {
            return source.Where(it => !predicate(it));
        }
		#endregion

		#region 10_SLICE
		public static IEnumerable<TSource> Islice<TSource>
		(
			this IEnumerable<TSource> source,
			int start,
			int stop,
			int step = 1
		)
		{
			return IsliceFunction.Islice(source, start, stop, step);
		}
		#endregion

		#region 12_STARMAP
		public static IEnumerable<TResult> Starmap<T1, T2, TResult>
        (
            Func<T1, T2, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, TResult>
        (
            Func<T1, T2, T3, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, TResult>
        (
            Func<T1, T2, T3, T4, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, TResult>
        (
            Func<T1, T2, T3, T4, T5, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, T6, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }

        public static IEnumerable<TResult> Starmap<T1, T2, T3, T4, T5, T6, T7, TResult>
        (
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> valueFactory,
            IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> iterable
        )
        {
            return StarmapFunction.Starmap
            (
                valueFactory,
                iterable
            );
        }
        #endregion

        #region 15_PRODUCT
        public static IEnumerable<Tuple<T1, T2>> Product<T1, T2>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            int repeat=1
        )
        {
            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                repeat
            );
        }

        public static IEnumerable<Tuple<T1, T2, T3>> Product<T1, T2, T3>
        (
            IEnumerable<T1> iterable0,
            IEnumerable<T2> iterable1,
            IEnumerable<T3> iterable2,
            int repeat=1
        )
        {
            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                iterable2,
                repeat
            );
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
            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                iterable2,
                iterable3,
                repeat
            );
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
            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                iterable2,
                iterable3,
                iterable4,
                repeat
            );
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
            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                iterable2,
                iterable3,
                iterable4,
                iterable5,
                repeat
            );
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

            return ProductFunction.Product
            (
                iterable0,
                iterable1,
                iterable2,
                iterable3,
                iterable4,
                iterable5,
                iterable6,
                repeat
            );
        }
        #endregion

        #region 14_TAKEWHILE
        public static IEnumerable<TSource> TakeWhile<TSource>
        (
			this IEnumerable<TSource> source,
            Func<TSource, int, bool> predicate
        )
        {
            return source.TakeWhile(predicate);
        }

        public static IEnumerable<TSource> TakeWhile<TSource>
        (
            this IEnumerable<TSource> source,
            Func<TSource, bool> predicate
        )
        {
            return source.TakeWhile(predicate);
        }
        #endregion
    }
}
