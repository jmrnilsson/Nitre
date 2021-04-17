using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class CombinationsTests
    {
		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact]
		public void Verified_Example()
		{
			var iterables = "ABCD".ToCharArray();

			// var actual = new string(Nitre.Permutations(iterables, 2).ToArray());
			var expected = new List<string> { "AB", "AC", "AD", "BA", "BC", "BD", "CA", "CB", "CD", "DA", "DB", "DC" };

			Assert.False(true);
			Assert.Equal(expected, new List<string> { "actual" });
		}
	}
}
