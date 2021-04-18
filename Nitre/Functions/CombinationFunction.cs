using System;
using System.Collections.Generic;
using System.Linq;

namespace Nitre.Functions
{
	/// <summary>
	/// https://english.stackexchange.com/questions/25116/what-follows-next-in-the-sequence-unary-binary-ternary
	/// </summary>
	internal static class CombinationFunction
	{
		internal static IEnumerable<Tuple<T, T>> CombinationsBinary<T>(this IEnumerable<T> iterable)
		{
			var rest = iterable.Skip(1);

			if (rest.Any())
			{
				foreach (var values in CombinationsBinary(iterable.ElementAt(0), rest, false))
				{
					yield return values;
				}
			}
		}

		private static IEnumerable<Tuple<T, T>> CombinationsBinary<T>(T current, IEnumerable<T> rest, bool withReplacements)
		{
			int length = 0;
			foreach(var value in rest)
			{
				yield return Tuple.Create(current, value);
				length += 1;
			}

			int index = withReplacements ? 1 : 0;

			if (length > 1)
			{
				foreach(var values in CombinationsBinary<T>(rest.ElementAt(index), rest.Skip(1), withReplacements))
				{
					yield return values;
				}
			}
		}

		internal static IEnumerable<Tuple<T, T>> CombinationsWithReplacementsBinary<T>(this IEnumerable<T> iterable)
		{
			if (iterable.Any())
			{
				foreach (var values in CombinationsBinary(iterable.ElementAt(0), iterable, true))
				{
					yield return values;
				}
			}
		}

		internal static IEnumerable<Tuple<T, T, T>> CombinationsTernary<T>(this IEnumerable<T> iterable)
		{
			for(int i = 1; i < iterable.Count(); i++)
			{
				var rest = iterable.Skip(i);

				foreach (var values in CombinationsTernary<T>(iterable.ElementAt(i - 1), rest))
				{
					yield return values;
				}
			}
		}

		private static IEnumerable<Tuple<T, T, T>> CombinationsTernary<T>(T current, IEnumerable<T> rest)
		{
			if (rest.Any())
			{
				foreach (var values in CombinationsBinary<T>(rest.ElementAt(0), rest.Skip(1), false))
				{
					yield return Tuple.Create(current, values.Item1, values.Item2);
				}
			}
		}

		internal static IEnumerable<Tuple<T, T, T, T>> CombinationsQuaternary<T>(this IEnumerable<T> iterable)
		{
			for (int i = 1; i < 3; i++)
			{
				var rest = iterable.Skip(i);

				foreach (var values in CombinationsQuaternary<T>(iterable.ElementAt(i - 1), rest))
				{
					yield return values;
				}
			}
		}

		private static IEnumerable<Tuple<T, T, T, T>> CombinationsQuaternary<T>(T current, IEnumerable<T> rest)
		{
			if (rest.Any())
			{
				foreach (var values in CombinationsTernary(rest.ElementAt(0), rest.Skip(1)))
				{
					yield return Tuple.Create(current, values.Item1, values.Item2, values.Item3);
				}
			}
		}

		internal static IEnumerable<Tuple<T, T, T, T, T>> CombinationsQuinary<T>(this IEnumerable<T> iterable)
		{
			for (int i = 1; i < 4; i++)
			{
				var rest = iterable.Skip(i);

				foreach (var values in CombinationsQuinary(iterable.ElementAt(i - 1), rest))
				{
					yield return values;
				}
			}
		}

		private static IEnumerable<Tuple<T, T, T, T, T>> CombinationsQuinary<T>(T current, IEnumerable<T> rest)
		{
			if (rest.Any())
			{
				foreach (var values in CombinationsQuaternary(rest.ElementAt(0), rest.Skip(1)))
				{
					yield return Tuple.Create(current, values.Item1, values.Item2, values.Item3, values.Item4);
				}
			}
		}
	}
}
