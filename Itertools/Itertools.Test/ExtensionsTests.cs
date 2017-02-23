using System.Collections.Immutable;
using System.Linq;
using Xunit;

namespace Itertools.Test
{
    public class ExtensionsTests
    {
        [Fact]
        public void Filter()
        {
            var iterable0 = Utils.RangeOfChars(3);
            var iterable1 = Utils.RangeOfChars(5);
            var iterable2 = Enumerable.Range(0, 10);

            var actual =
                Itertools.Product(iterable0, iterable1, iterable2)
                .Filter((a, b, _) => a == 'A' && b == 'E')
                .Filter((_, __, c) => c == 5 || c == 7)
                .ToList();

            var actual0 = actual.Select(t => t.Item1).ToList();
            var actual1 = actual.Select(t => t.Item2).ToList();
            int numberMax = actual.Select(t => t.Item3).Max();

            Assert.Equal(2, actual.Count);
            Assert.Contains('A', actual0);
            Assert.Contains('E', actual1);
            Assert.DoesNotContain('B', actual1);
            Assert.Equal(7, numberMax);
        }

        [Fact]
        public void FilterForIndexAndImmutableCollection_AssertOrder()
        {
            var iterable0 = Utils.RangeOfChars(3).ToArray();
            var iterable1 = Utils.RangeOfChars(5, 70).ToList();
            var iterable2 = Enumerable.Range(0, 4).ToImmutableArray();
            var tuple0 = Itertools.Product(iterable0, iterable1, iterable2).ToArray();
            var tuple1 = Itertools.Product(iterable2, iterable0, iterable1).ToArray();

            var actual0 =
                tuple0
                .Filter((a, b, c, i) => i == 50)
                .Single();

            var actual1 =
                tuple1
                .Filter((a, b, c, i) => i == 50)
                .Single();


            Assert.Equal('C', actual0.Item1);
            Assert.Equal(2, actual0.Item3);
            Assert.Equal(3, actual1.Item1);
            Assert.True(actual0.Item1 > actual1.Item1);
        }
    }
}