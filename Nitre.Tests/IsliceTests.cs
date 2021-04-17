using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
	public class IsliceTests
	{
		[Fact]
		public void DefaultStep()
		{
			var iterable0 = Enumerable.Range(0, 20);
			var actual = Nitre.Islice(iterable0, 15, 20);

			Assert.Equal(new List<int> { 15, 16, 17, 18, 19 }, actual);
		}

		[Fact]
		public void ForNegativeValues()
		{
			var iterable0 = Enumerable.Range(0, 2);
			var actual = Nitre.Islice(iterable0, 0, -1, 0);

			Assert.Throws<ArgumentException>(() => Nitre.Islice(iterable0, 0, -1, 0).ToList());
			Assert.Throws<ArgumentException>(() => Nitre.Islice(iterable0, 1, 3, -2).ToList());
			Assert.Throws<ArgumentException>(() => Nitre.Islice(iterable0, -23, 0, 0).ToList());
		}

		[Fact]
		public void OutOfBounds()
		{
			var iterable0 = Enumerable.Range(0, 3);
			var actual = Nitre.Islice(iterable0, 0, 5);

			Assert.Equal(new List<int> { 0, 1, 2 }, actual);
		}

		[Fact]
		public void ForNonIndexed_AndOverloaded()
		{
			var iterable0 = Enumerable.Range(0, 12);
			var actual = iterable0.Islice(1, 10, 2).ToList();

			Assert.Equal(new List<int> { 1, 3, 5, 7, 9 }, actual);
		}
	}
}
