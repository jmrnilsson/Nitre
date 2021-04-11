using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class FilterFalseTests
    {
        [Fact]
        public void ForIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Itertools.FilterFalse(iterable0, (it, i) => i % 2 == 0 && it % 3 == 0).ToList();

            Assert.Equal(10, actual.Count);
            Assert.DoesNotContain(6, actual);
            Assert.DoesNotContain(12, actual);
        }

        [Fact]
        public void ForNonIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Itertools.FilterFalse(iterable0, it => it < 4).ToList();

            Assert.Equal(8, actual.Count);
            Assert.DoesNotContain(2, actual);
            Assert.Contains(4, actual);
        }
    }
}