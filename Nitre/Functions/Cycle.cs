using System.Collections.Generic;

namespace Nitre.Functions
{
	internal static class CycleFunction
	{
		internal static IEnumerable<T> Cycle<T>(this IEnumerable<T> iterable)
		{
			do
			{
				using (var sequence = iterable.GetEnumerator())
				{
					while (sequence.MoveNext())
					{
						yield return sequence.Current;
					} 
				}
			} while (true);
		}
	}
}
