using System;
using System.Collections.Generic;
using Itertools.Functions;
using Xunit;

namespace Itertools.Tests
{
    delegate double MathDelegate(double i, double j);
    delegate void VoidDelegate(double i, double j);

    public class ApplyTests
    {
        [Fact]
        public void Func()
        {
            var arguments = Tuple.Create('a', "_simple_tuple_of_arguments");
            Func<char, string, string> func = (a, b) => $"{a}{b}";
            string actual = ApplyFunction.Apply(func, arguments);
            Assert.StrictEqual("a_simple_tuple_of_arguments", actual);
        }


        [Fact(Skip = "Unsupported")]
        public void Action()
        {
        }

        [Fact]
        public void Delegate()
        {
            MathDelegate m = (i, j) => i + j;
            var arguments = Tuple.Create('a', "_simple_tuple_of_arguments");
            Func<char, string, string> func = (a, b) => $"{a}{b}";
            string actual = ApplyFunction.Apply(func, arguments);
            Assert.StrictEqual("a_simple_tuple_of_arguments", actual);
        }

        [Fact(Skip = "Unsupported")]
        public void VoidDelegate()
        {
            VoidDelegate func = delegate { };
            int counter = 0;
            func += delegate { counter++; };
            // string actual = ApplyFunction.Apply(func, Tuple.Create(2d, 5d));
            // Assert.StrictEqual("a_simple_tuple_of_arguments", actual);
        }

        [Fact]
        public void StaticMethod()
        {
            double actual = ApplyFunction.Apply(Math.Pow, Tuple.Create(2d, 3d));
            Assert.StrictEqual(8, actual);
        }

        [Fact(Skip = "Unsupported")]
        public void VoidStaticMethod()
        {
        }

        [Fact]
        public void VoidMethod()
        {
            var list = new Dictionary<char, string>();
            ApplyFunction.Apply(list.Add, Tuple.Create('a', "beta"));
            ApplyFunction.Apply(list.Add, Tuple.Create('b', "alfa"));
            Assert.StrictEqual(2, list.Count);
        }
    }
}