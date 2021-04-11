using System;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class StarmapTests
    {
        [Fact]
        public void WithTwoTuples()
        {
            var iterable0 = new[] {Tuple.Create(1, "first"), Tuple.Create(3, "second")};
            var actual = Itertools.Starmap((a, b) => $"{a}{b}", iterable0);

            Assert.StrictEqual("1first3second", string.Join("", actual));
        }

        private dynamic Reduce7Arguments(string a, int b, decimal c, int d, int e, int f, int g)
        {
            return new {name = a, area = b * c, sum = d + e + f + g};
        }

        [Fact]
        public void WithSevenTuples()
        {
            var iterable0 = new[] {Tuple.Create("A", 101, 1.2m, 0, 0, 1, 3), Tuple.Create("B", 3, .3m, 1, 1, 1, 1)};
            var actual = Itertools.Starmap(Reduce7Arguments, iterable0).ToList();

            Assert.Equal("A", actual[0].name);
            Assert.Equal(4, actual[0].sum);
            Assert.Equal(101 * 1.2m, actual[0].area);
            Assert.Equal("B", actual[1].name);
            Assert.Equal(3 * .3m, actual[1].area);
        }
    }
}
