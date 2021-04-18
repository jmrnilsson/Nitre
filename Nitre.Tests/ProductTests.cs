using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class ProductTestss
    {
        [Fact]
        public void WithTwoLists()
        {
            var expected0 = new Tuple<int, char>(1, 'A');
            var expected2 = new Tuple<int, char>(1, 'C');
            var expected11 = new Tuple<int, char>(3, 'D');

            var iterable0 = Enumerable.Range(1, 3);
            var iterable1 = Utils.RangeOfChars(4);
            var actual = Nitre.Product(iterable0, iterable1).ToList();

            Assert.StrictEqual(12, actual.Count);
            Assert.Equal(expected0, actual[0]);
            Assert.Equal(expected2, actual[2]);
            Assert.Equal(expected11, actual[11]);
        }

        [Fact]
        public void WithRepeat()
        {
            var expected1 = new Tuple<int, char>(1, 'C');
            var expected29 = new Tuple<int, char>(5, 'C');

            var iterable0 = Enumerable.Range(1, 5);
            var iterable1 = Utils.RangeOfChars(3);
            var actual = Nitre.Product(iterable0, iterable1, 2).ToList();

            Assert.StrictEqual(30, actual.Count);
            Assert.Equal(expected1, actual[2]);
            Assert.Equal(expected29, actual[29]);
            Assert.Equal(actual[13], actual[28]);
        }

        [Fact]
        public void WithInvalidRepeatThrows()
        {
            Action action = () => Nitre.Product(new int[]{}, new int[]{}, -1).ToList();

            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public void WithSevenIterables()
        {
            var iterables = new Dictionary<int, IEnumerable<char>>();
            for (var i = 0; i < 50; i++)
            {
                iterables[i] = Utils.RangeOfChars(3, 65 + i);
            }

            var expected2 = new Tuple<char, char, char, char, char, char, char>
            (
                'A', 'B', 'C', 'D', 'E', 'F', 'I'
            );
            var expected2184 = new Tuple<char, char, char, char, char, char, char>
            (
                'C', 'D', 'E', 'F', 'G', 'H', 'G'
            );

            var actual = Nitre.Product
            (
                iterables[0],
                iterables[1],
                iterables[2],
                iterables[3],
                iterables[4],
                iterables[5],
                iterables[6]
            ).ToList();

            Assert.StrictEqual(actual.Count, Math.Pow(3, 7));
            Assert.Equal(expected2, actual[2]);
            Assert.Equal(expected2184, actual[2184]);
        }

		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact(Skip = "Not implemented yet")]
		public void VerifiedExample()
		{
			var iterables = "ABCD".ToCharArray();

			// var actual = new string(Nitre.Product(iterables, repeat: 2).ToArray());
			var expected = new List<string> { "AA", "AB", "AC", "AD", "BA", "BB", "BC", "BD", "CA", "CB", "CC", "CD", "DA", "DB", "DC", "DD" };

			Assert.False(true);
			Assert.Equal(expected, new List<string> { "actual" });
		}
	}
}
