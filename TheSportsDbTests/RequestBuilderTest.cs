using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheSportsDB;
using Xunit;

namespace TheSportsDbTests
{
    public class RequestBuilderTest
    {
        private const string ApiKey = "2";

        [Fact]
        public async Task Request_WhenParamIsNull()
        {
            // Arrange
            var endpoint = Endpoints.SearchAllSports;
            var retryAttempts = 1;
            var pauseBetweenFailures = TimeSpan.FromSeconds(2);
            var expectedParams = new Dictionary<string, string>();

            var requestBuilder = new RequestBuilder(ApiKey);

            // Act
            var requestBuilderResult = await requestBuilder.Request(endpoint, null);

            // Assert
            Assert.NotNull(requestBuilderResult);
            Assert.Equal(ApiKey, requestBuilder.APIKey);
            Assert.Equal(retryAttempts, requestBuilder.MaxRetryAttempts);
            Assert.Equal(pauseBetweenFailures, requestBuilder.PauseBetweenFailures);
            Assert.Equal(expectedParams, requestBuilder.Parameters);
        }

        [Fact]
        public async Task Request_WhenParamIsNotNull()
        {
            // Arrange
            var endpoint = Endpoints.SearchPlayers;
            var retryAttempts = 1;
            var pauseBetweenFailures = TimeSpan.FromSeconds(2);
            var expectedParams = new Dictionary<string, string>()
            {
                {"p", "Cristiano" }
            };

            var requestBuilder = new RequestBuilder(ApiKey);

            // Act
            var requestBuilderResult = await requestBuilder.Request(endpoint, expectedParams);

            // Assert
            Assert.NotNull(requestBuilderResult);
            Assert.Equal(ApiKey, requestBuilder.APIKey);
            Assert.Equal(retryAttempts, requestBuilder.MaxRetryAttempts);
            Assert.Equal(pauseBetweenFailures, requestBuilder.PauseBetweenFailures);
            Assert.Equal(expectedParams, requestBuilder.Parameters);
        }

        [Fact]
        public async Task Request_ShouldReturnNull()
        {
            // Arrange
            var endpoint = "this_endpoint_is_imaginary";
            var retryAttempts = 3;
            var pauseBetweenFailures = TimeSpan.FromSeconds(1);
            var expectedParams = new Dictionary<string, string>();

            var requestBuilder = new RequestBuilder(ApiKey, retryAttempts, pauseBetweenFailures);

            // Act
            var result = await requestBuilder.Request(endpoint, null);

            // Assert
            Assert.Null(result);
            Assert.Equal(ApiKey, requestBuilder.APIKey);
            Assert.Equal(retryAttempts, requestBuilder.MaxRetryAttempts);
            Assert.Equal(pauseBetweenFailures, requestBuilder.PauseBetweenFailures);
            Assert.Equal(expectedParams, requestBuilder.Parameters);
        }
    }
}