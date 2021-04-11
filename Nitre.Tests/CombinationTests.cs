using System;
using System.Linq;
using Xunit;

namespace Itertools.Test
{
    public class CombinationTests
    {
        [Fact]
        public void ProductFilter()
        {
            var iterables = Create();

            var actual =
                Itertools.Product(iterables.Item1, iterables.Item2, iterables.Item3)
                .Filter((l, m, _) => l.MunicipalityId == m.MunicipalityId)
                .Filter((_, m, c) => m.IsoCode == c.IsoCode || "GB" == c.IsoCode)
                .ToArray();

            var countries = actual.Select(t => t.Item3.IsoCode).ToArray();
            var municipalities = actual.Select(t => t.Item2.IsoCode).ToArray();
            var libraries = actual.Select(t => t.Item1.MunicipalityId).ToArray();

            Assert.Contains("GB", countries);
            Assert.Contains("CN", countries);
            Assert.DoesNotContain("IN", countries);
            Assert.Contains("CN", municipalities);
            Assert.Contains("XL", municipalities);
            Assert.DoesNotContain("IL", municipalities);
            Assert.Contains(3, libraries);
        }

        internal class Library
        {
            internal int MunicipalityId { get; set; }
        }

        internal class Municipality
        {
            internal int MunicipalityId { get; set; }
            internal string IsoCode { get; set; }
        }

        internal class Country
        {
            internal string IsoCode { get; set; }
        }

        private Tuple<Library[], Municipality[], Country[]> Create()
        {
            var libraries = new[]
            {
                new Library {MunicipalityId = 1},
                new Library {MunicipalityId = 2},
                new Library {MunicipalityId = 3},
            };
            var municipalities = new[]
            {
                new Municipality {MunicipalityId = 99, IsoCode = "IL"},
                new Municipality {MunicipalityId = 2, IsoCode = "CN"},
                new Municipality {MunicipalityId = 3, IsoCode = "XL"},
            };
            var countries = new[]
            {
                new Country {IsoCode = "IL"},
                new Country {IsoCode = "GB"},
                new Country {IsoCode = "UL"},
                new Country {IsoCode = "IN"},
                new Country {IsoCode = "CN"}
            };
            return Tuple.Create(libraries, municipalities, countries);
        }

    }
}