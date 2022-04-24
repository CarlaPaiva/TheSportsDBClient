using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSportsDB;
using Xunit;

namespace TheSportsDbTests
{
    public class TheSportsDbClientTest
    {
        [Fact]
        public async Task ReturnAllSports()
        {
            // Arrange
            var client = new TheSportsDbClient();

            // Act
            var result = await client.ListAllSportsAsync();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ReturnAllCountries()
        {
            // Arrange
            var client = new TheSportsDbClient();

            // Act
            var result = await client.ListAllCountries();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ReturnAllLeagues()
        {
            // Arrange
            var client = new TheSportsDbClient();

            // Act
            var result = await client.ListAllLeaguesAsync();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ReturnAllLeaguesByCountry()
        {
            // Arrange
            var client = new TheSportsDbClient();
            var country = "Brazil";

            // Act
            var result = await client.ListAllLeaguesByCountryAsync(country);

            // Assert
            Assert.NotNull(result);
        }

    }
}