using System;
using System.Collections.Generic;
using System.Linq;

namespace Nitre.Functions
{
	internal static class IsliceFunction
	{
		internal static IEnumerable<T> Islice<T>(this IEnumerable<T> iterable, int start, int stop, int step)
		{
			// Islice doesn't support negative values.
			// https://docs.python.org/3/library/itertools.html#itertools.islice
			if (step < 1)
			{
				throw new ArgumentException("Value is zero or negative", nameof(step));
			}
			if (start < 0)
			{
				throw new ArgumentException("Value is zero or negative", nameof(start));
			}
			if (stop < 0)
			{
				throw new ArgumentException("Value is zero or negative", nameof(stop));
			}

			else if (step > 0)
			{
				using (var sequence = iterable.Skip(start).Take(stop - start).GetEnumerator())
				{
					int i = 0;
					while (sequence.MoveNext())
					{
						if (i++ % step != 0)
						{
							continue;
						}

						yield return sequence.Current;
					}
				}
			}
		}
	}
}
