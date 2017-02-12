using System;
using Itertools.Functions;
using Xunit;

namespace Itertools.Tests
{
    public class ApplyTests
    {
        [Fact]
        public void ForATuple()
        {
            var arguments = Tuple.Create('a', "_simple_tuple_of_arguments");
            Func<char, string, string> func = (a, b) => $"{a}{b}";
            string actual = ApplyFunction.Apply(func, arguments);
            Assert.StrictEqual("a_simple_tuple_of_arguments", actual);
        }
    }
}