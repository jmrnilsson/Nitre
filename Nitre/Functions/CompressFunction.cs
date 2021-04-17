using System.Collections.Generic;

namespace Nitre.Functions
{
	internal static class CompressFunction
	{
		internal static IEnumerable<T> Compress<T>(this IEnumerable<T> iterable, IEnumerable<bool> iterable0)
		{
			using (var sequence = iterable.GetEnumerator())
			{
				using (var expressions = iterable0.GetEnumerator())
				{
					while (sequence.MoveNext() && expressions.MoveNext())
					{
						if (expressions.Current)
						{
							yield return sequence.Current;
						}
					}
				}
			}
		}
	}
}
