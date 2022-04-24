using System;
using System.Collections.Generic;
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
            var client = new TheSportsDbClient("2");

            // Act
            var result = await client.ListAllSportsAsync();

            // Assert
            Assert.NotNull(result);
        }

    }
}