using System.Linq;
using Xunit;

namespace Itertools.Test
{
    public class TakeWhileTests
    {
        [Fact]
        public void ForIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Itertools.TakeWhile(iterable0, (it, i) => i < 4 && (it < 3 || it % 3 == 0)).ToList();

            Assert.Equal(4, actual.Count);
            Assert.Equal(1, actual[1]);
        }

        [Fact]
        public void ForNonIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Itertools.TakeWhile(iterable0, it => it < 4).ToList();

            Assert.Equal(4, actual.Count);
            Assert.Equal(3, actual[3]);
        }
    }
}