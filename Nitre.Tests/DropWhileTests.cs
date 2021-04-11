using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
	public class DropWhileTests
    {
        [Fact]
        public void ForIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Nitre.DropWhile(iterable0, (it, index) => index < 9 || it % 3 == 0).ToList();

            Assert.Equal(new List<int> { 10, 11 }, actual);
        }

        [Fact]
        public void ForNonIndexed_AndOverloaded()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = iterable0.DropWhile(it => it < 4).ToList();

            Assert.Equal(8, actual.Count);
            Assert.Equal(5, actual[1]);
        }
    }
}
