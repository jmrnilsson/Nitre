using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class PermutationsTests
    {
		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact]
		public void Verified_Example()
		{
			var iterables = "ABCD".ToCharArray();

			// var actual = new string(Nitre.Combinations(iterables, 2).ToArray());
			var expected = new List<string> { "AB", "AC", "AD", "BC", "BD", "CD" };

			Assert.False(true);
			Assert.Equal(expected, new List<string> { "actual" });
		}

		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact]
		public void Verified_Example_WithReplacements()
		{
			var iterables = "ABCD".ToCharArray();

			// var actual = new string(Nitre.CombinationsWithReplacement(iterables, 2).ToArray());
			var expected = new List<string> { "AA", "AB", "AC", "AD", "BB", "BC", "BD", "CC", "CD", "DD" };

			Assert.False(true);
			Assert.Equal(expected, new List<string> { "actual" });
		}
	}
}
