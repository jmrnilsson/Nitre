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
		public void VerifiedExample()
		{
			var iterables = "ABCD".ToCharArray();

			var actual = Nitre.CombinationsBinary(iterables).Select(item => new string(new char[] { item.Item1, item.Item2 }));
			var expected = new List<string> { "AB", "AC", "AD", "BC", "BD", "CD" };

			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact]
		public void VerifiedExample_WithReplacements()
		{
			var iterables = "ABCD".ToCharArray();

			var actual = Nitre.CombinationsWithReplacementsBinary(iterables).Select(item => new string(new char[] { item.Item1, item.Item2 })).ToList();
			var expected = new List<string> { "AA", "AB", "AC", "AD", "BB", "BC", "BD", "CC", "CD", "DD" };

			Assert.Equal(expected, actual);
		}

		/*
		public static IEnumerable<object[]> REPL_Data()
		{
			return new List<object[]>
			{
				new object[] { "ABCD", 2, new List<(char, char)> { ('A', 'B'), ('A', 'C'), ('A', 'D'), ('B', 'C'), ('B', 'D'), ('C', 'D') } },
				new object[] { "ABCD", 3, new List<(char, char, char)> { ('A', 'B', 'C'), ('A', 'B', 'D'), ('A', 'C', 'D'), ('B', 'C', 'D') } },
				new object[] { "ABCD", 4, new List<(char, char, char, char)> { ('A', 'B', 'C', 'D') } },
				new object[] { "ABCD", 5, Enumerable.Empty<(char, char, char, char, char)>() }
			};
		}
		*/

		[Fact]
		public void Repl_BinaryTuple()
		{
			List<Tuple<char, char>> expected = new List<Tuple<char, char>>
			{
				Tuple.Create('A', 'B'),
				Tuple.Create('A', 'C'),
				Tuple.Create('A', 'D'),
				Tuple.Create('B', 'C'),
				Tuple.Create('B', 'D'),
				Tuple.Create('C', 'D')
			};

			char[] iterable = "ABCD".ToCharArray();

			List<Tuple<char, char>> actual = Nitre.CombinationsBinary(iterable).ToList();
			// var actual_ = partialResult.Select(r => new string(new char[] { r.Item1, r.Item2 }));
			
			// Assert.False(true);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Repl_TernaryTuple()
		{
			List<Tuple<char, char, char>> expected = new List<Tuple<char, char, char>>
			{
				Tuple.Create('A', 'B', 'C'),
				Tuple.Create('A', 'B', 'D'),
				Tuple.Create('A', 'C', 'D'),
				Tuple.Create('B', 'C', 'D')
			};

			char[] iterable = "ABCD".ToCharArray();

			List<Tuple<char, char, char>> actual = Nitre.CombinationsTernary(iterable).ToList();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Repl_QuaternaryTuple()
		{
			List<Tuple<char, char, char, char>> expected = new List<Tuple<char, char, char, char>>
			{
				Tuple.Create('A', 'B', 'C', 'D')
			};

			char[] iterable = "ABCD".ToCharArray();

			var actual = Nitre.CombinationsQuaternary(iterable).ToList();

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Repl_QuinaryTuple()
		{
			var expected = Enumerable.Empty<Tuple<char, char, char, char, char>>();

			char[] iterable = "ABCD".ToCharArray();

			var actual = Nitre.CombinationsQuinary(iterable).ToList();

			Assert.Equal(expected, actual);
		}

	}
}
