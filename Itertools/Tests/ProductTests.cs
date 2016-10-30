using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Itertools.Tests
{
    public class ProductTest
    {
        [Fact]
        public void ForWithRepeat()
        {
            var expected1 = new Tuple<int, char>(1, 'C');
            var expected29 = new Tuple<int, char>(5, 'C');

            var iterable0 = Enumerable.Range(1, 5);
            var iterable1 = Utils.RangeOfChars(3);
            var actual = Itertools.Product(iterable0, iterable1, 2).ToList();

            Assert.StrictEqual(actual.Count, 30);
            Assert.Equal(expected1, actual[2]);
            Assert.Equal(expected29, actual[29]);
            Assert.Equal(actual[13], actual[28]);
        }
    }
}
