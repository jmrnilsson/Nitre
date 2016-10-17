using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Itertools.Tests
{
    public class CountTests
    {
        [Fact]
        public void CountIntWithStep()
        {
            var actual = Itertools.Count(0, 3).Take(10).ToList();

            Assert.StrictEqual(10, actual.Count);
            Assert.Equal(0, actual[0]);
            Assert.Equal(9, actual[3]);
        }

        [Fact]
        public void CountFloatWithNegativeStep()
        {
            var actual = Itertools.Count(6f, -7f).Take(3).ToList();

            Assert.Equal(new List<float> {6f, -1f, -8}, actual);
        }

        [Fact]
        public void CountNegativeDoubleWithoutStep()
        {
            var actual = Itertools.Count(-2d).Take(3).ToList();

            Assert.Equal(new List<double> {-2d, -1d, 0d}, actual);
        }

        [Fact]
        public void CountDecimalWithStep()
        {
            var actual = Itertools.Count(1.1m, -0.4m).Take(3).ToList();

            Assert.Equal(new List<decimal> {1.1m, 0.7m, 0.3m}, actual);
        }

        [Fact]
        public void CountAllowedTypes()
        {
            var actual = typeof(Itertools).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(mi => mi.Name == "Count")
                .Select(mi => mi.GetParameters()[0].ParameterType)
                .ToList();

            Assert.Contains(typeof(decimal), actual);
            Assert.Contains(typeof(double), actual);
            Assert.Contains(typeof(int), actual);
            Assert.Contains(typeof(float), actual);
        }
    }
}
