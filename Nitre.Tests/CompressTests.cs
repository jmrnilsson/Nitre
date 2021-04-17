using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Nitre.Test
{
    public class CompressTests
    {
		[Fact]
		public void Default()
		{
			var values = Enumerable.Range(0, 3);
			var booleans = new[] { true, false, true };
			var actual = Nitre.Compress(values, booleans);

			Assert.Equal(new List<int> { 0, 2 }, actual);
		}

		[Fact]
		public void BooleansLonger_Unverified()
		{
			var values = Enumerable.Range(0, 5);
			var booleans = new[] { false, true, false, true, false, false, true, true };
			var actual = values.Compress(booleans);

			Assert.Equal(new List<int> { 1, 3 }, actual);
		}

		[Fact]
		public void ValuesLonger_Unverified()
		{
			var values = Enumerable.Range(0, 4);
			var booleans = new[] { false, true, false };
			var actual = values.Compress(booleans);

			Assert.Equal(new List<int> { 1 }, actual);
		}
	}
}
