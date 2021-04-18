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
		public void Repl_BinaryTuple_Empty()
		{
			var expected = Enumerable.Empty<Tuple<char, char>>();

			char[] iterable = "A".ToCharArray();

			List<Tuple<char, char>> actual = Nitre.CombinationsBinary(iterable).ToList();

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
		public void Repl_TernaryTuple_Empty()
		{
			var expected = Enumerable.Empty<Tuple<char, char, char>>();

			char[] iterable = "AB".ToCharArray();

			List<Tuple<char, char, char>> actual = Nitre.CombinationsTernary(iterable).ToList();

			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// [''.join(v) for v in combinations('ABCDEF', 3)]
		/// </summary>
		[Fact]
		public void Repl_TernaryTuple_Long()
		{
			var expected = new string[]
			{
				"ABC", "ABD", "ABE", "ABF", "ACD", "ACE", "ACF", "ADE", "ADF", "AEF", "BCD", "BCE", "BCF", "BDE", "BDF", "BEF", "CDE", "CDF", "CEF", "DEF"
			};

			char[] iterable = "ABCDEF".ToCharArray();

			var actual = Nitre.CombinationsTernary(iterable).Select(item => new string(new char[] { item.Item1, item.Item2, item.Item3 })).ToList();

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
		public void Repl_QuaternaryTuple_Empty()
		{
			var expected = Enumerable.Empty<Tuple<char, char, char, char>>();

			char[] iterable = "ABC".ToCharArray();

			List<Tuple<char, char, char, char>> actual = Nitre.CombinationsQuaternary(iterable).ToList();

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Repl_QuinaryTuple_Empty()
		{
			var expected = Enumerable.Empty<Tuple<char, char, char, char, char>>();

			char[] iterable = "ABCD".ToCharArray();

			var actual = Nitre.CombinationsQuinary(iterable).ToList();

			Assert.Equal(expected, actual);
		}

		/// <summary>
		/// [''.join(v) for v in combinations('ABCDEFGHIJ', 5)]
		/// </summary>
		[Fact]
		public void Repl_QuinaryTuple()
		{
			string[] expected = new string[] {
				"ABCDE", "ABCDF", "ABCDG", "ABCDH", "ABCDI", "ABCDJ", "ABCEF", "ABCEG", "ABCEH", "ABCEI", "ABCEJ", "ABCFG", "ABCFH",
				"ABCFI", "ABCFJ", "ABCGH", "ABCGI", "ABCGJ", "ABCHI", "ABCHJ", "ABCIJ", "ABDEF", "ABDEG", "ABDEH", "ABDEI", "ABDEJ",
				"ABDFG", "ABDFH", "ABDFI", "ABDFJ", "ABDGH", "ABDGI", "ABDGJ", "ABDHI", "ABDHJ", "ABDIJ", "ABEFG", "ABEFH", "ABEFI",
				"ABEFJ", "ABEGH", "ABEGI", "ABEGJ", "ABEHI", "ABEHJ", "ABEIJ", "ABFGH", "ABFGI", "ABFGJ", "ABFHI", "ABFHJ", "ABFIJ",
				"ABGHI", "ABGHJ", "ABGIJ", "ABHIJ", "ACDEF", "ACDEG", "ACDEH", "ACDEI", "ACDEJ", "ACDFG", "ACDFH", "ACDFI", "ACDFJ",
				"ACDGH", "ACDGI", "ACDGJ", "ACDHI", "ACDHJ", "ACDIJ", "ACEFG", "ACEFH", "ACEFI", "ACEFJ", "ACEGH", "ACEGI", "ACEGJ",
				"ACEHI", "ACEHJ", "ACEIJ", "ACFGH", "ACFGI", "ACFGJ", "ACFHI", "ACFHJ", "ACFIJ", "ACGHI", "ACGHJ", "ACGIJ", "ACHIJ",
				"ADEFG", "ADEFH", "ADEFI", "ADEFJ", "ADEGH", "ADEGI", "ADEGJ", "ADEHI", "ADEHJ", "ADEIJ", "ADFGH", "ADFGI", "ADFGJ",
				"ADFHI", "ADFHJ", "ADFIJ", "ADGHI", "ADGHJ", "ADGIJ", "ADHIJ", "AEFGH", "AEFGI", "AEFGJ", "AEFHI", "AEFHJ", "AEFIJ",
				"AEGHI", "AEGHJ", "AEGIJ", "AEHIJ", "AFGHI", "AFGHJ", "AFGIJ", "AFHIJ", "AGHIJ", "BCDEF", "BCDEG", "BCDEH", "BCDEI",
				"BCDEJ", "BCDFG", "BCDFH", "BCDFI", "BCDFJ", "BCDGH", "BCDGI", "BCDGJ", "BCDHI", "BCDHJ", "BCDIJ", "BCEFG", "BCEFH",
				"BCEFI", "BCEFJ", "BCEGH", "BCEGI", "BCEGJ", "BCEHI", "BCEHJ", "BCEIJ", "BCFGH", "BCFGI", "BCFGJ", "BCFHI", "BCFHJ",
				"BCFIJ", "BCGHI", "BCGHJ", "BCGIJ", "BCHIJ", "BDEFG", "BDEFH", "BDEFI", "BDEFJ", "BDEGH", "BDEGI", "BDEGJ", "BDEHI",
				"BDEHJ", "BDEIJ", "BDFGH", "BDFGI", "BDFGJ", "BDFHI", "BDFHJ", "BDFIJ", "BDGHI", "BDGHJ", "BDGIJ", "BDHIJ", "BEFGH",
				"BEFGI", "BEFGJ", "BEFHI", "BEFHJ", "BEFIJ", "BEGHI", "BEGHJ", "BEGIJ", "BEHIJ", "BFGHI", "BFGHJ", "BFGIJ", "BFHIJ",
				"BGHIJ", "CDEFG", "CDEFH", "CDEFI", "CDEFJ", "CDEGH", "CDEGI", "CDEGJ", "CDEHI", "CDEHJ", "CDEIJ", "CDFGH", "CDFGI",
				"CDFGJ", "CDFHI", "CDFHJ", "CDFIJ", "CDGHI", "CDGHJ", "CDGIJ", "CDHIJ", "CEFGH", "CEFGI", "CEFGJ", "CEFHI", "CEFHJ",
				"CEFIJ", "CEGHI", "CEGHJ", "CEGIJ", "CEHIJ", "CFGHI", "CFGHJ", "CFGIJ", "CFHIJ", "CGHIJ", "DEFGH", "DEFGI", "DEFGJ",
				"DEFHI", "DEFHJ", "DEFIJ", "DEGHI", "DEGHJ", "DEGIJ", "DEHIJ", "DFGHI", "DFGHJ", "DFGIJ", "DFHIJ", "DGHIJ", "EFGHI",
				"EFGHJ", "EFGIJ", "EFHIJ", "EGHIJ", "FGHIJ"
			};

			char[] iterable = "ABCDEFGHIJ".ToCharArray();

			var actual = Nitre.CombinationsQuinary(iterable).Select(item => new string(new char[] { item.Item1, item.Item2, item.Item3, item.Item4, item.Item5 })).ToList();


			Assert.Equal(expected, actual);
		}

	}
}
