using System;
using System.Linq;
using Xunit;

namespace Itertools.Tests
{
    public class StarmapTests
    {
        [Fact]
        public void For2Tuples()
        {
            var iterable0 = new[] {Tuple.Create(1, "first"), Tuple.Create(3, "second")};
            var actual = Itertools.Starmap((a, b) => $"{a}{b}", iterable0);

            Assert.StrictEqual("1first3second", string.Join("", actual));
        }

        [Fact]
        public void For3Tuples()
        {
            Func<string, int, decimal, dynamic> action = (name, width, height) => new { name, area = width * height };
            var iterable0 = new[] {Tuple.Create("A", 101, 1.2m), Tuple.Create("B", 3, .3m)};
            var actual = Itertools.Starmap(action, iterable0).ToList();

            Assert.Equal("A", actual[0].name);
            Assert.Equal(101 * 1.2m, actual[0].area);
            Assert.Equal("B", actual[1].name);
            Assert.Equal(3 * .3m, actual[1].area);
        }
    }
}
