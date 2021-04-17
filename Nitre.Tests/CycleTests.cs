using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace Nitre.Test
{
    public class CycleTests
    {
		[Fact]
		public void Default()
		{
			var values = "ABCD".ToCharArray();
			var actual = new string(Nitre.Cycle(values).Take(10).ToArray());

			Assert.Equal("ABCDABCDAB", actual);
		}

		[Fact]
		public void Overloaded()
		{
			var values = "ABCD".ToCharArray();
			var actual = new string(values.Cycle().Take(6).ToArray());

			Assert.Equal("ABCDAB", actual);
		}
	}
}
