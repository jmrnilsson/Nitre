using System;
using Xunit;

namespace Itertools.Tests
{
    public class StarmapTests
    {
        [Fact]
        public void StarmapWithLambda()
        {
            var iterable0 = new[] {Tuple.Create(1, "first"), Tuple.Create(3, "second")};
            var actual = Itertools.Starmap((a, b) => $"{a}{b}", iterable0);

            Assert.StrictEqual("1first3second", string.Join("", actual));
        }
    }
}
