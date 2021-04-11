using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Nitre.Test
{
    public class FilterTests
    {
        [Fact]
        public void ForIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
			List<int> actual = Itertools.Filter(iterable0, (it, i) => i % 2 == 0 && it % 3 == 0).ToList();

            Assert.Equal(new List<int>{0, 6}, actual);
        }

        [Fact]
        public void ForNonIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Itertools.Filter(iterable0, (_, index) => index > 7).ToList();

            Assert.Equal(new List<int> { 8, 9, 10, 11 }, actual);
        }

        [Fact]
        public void ForOverload()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = iterable0.Filter(it => it > 10).ToList();

            Assert.Equal(new List<int> { 11 }, actual);
        }
    }
}