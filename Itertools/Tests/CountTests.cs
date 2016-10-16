using System;
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
                .OrderBy(mi => mi.ToString())
                .ToList();

            Assert.Equal(actual[0], typeof(Decimal));
            Assert.Equal(actual[1], typeof(Double));
            // Assert.Equal(actual[2], typeof(Int16));
            Assert.Equal(actual[2], typeof(Int32));
            // Assert.Equal(actual[4], typeof(Int64));
            Assert.Equal(actual[3], typeof(Single));
            // Assert.Equal(actual[6], typeof(UInt16));
            // Assert.Equal(actual[7], typeof(UInt32));
            // Assert.Equal(actual[8], typeof(UInt64));
        }
    }
}