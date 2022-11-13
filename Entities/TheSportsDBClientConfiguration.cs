using System;

namespace Entities
{
    public class TheSportsDBClientConfiguration
    {
        private const string DefaultApiKey = "2";
        public string ApiKey { get; set; }
        public int RetryAttempts { get; set; }
        public TimeSpan IntervalBetweenAttempts { get; set; } = TimeSpan.FromSeconds(2);

        public TheSportsDBClientConfiguration()
        {
            this.ApiKey = DefaultApiKey;
        }

        public TheSportsDBClientConfiguration(string apiKey)
        {
            this.ApiKey = apiKey;
        }
        public TheSportsDBClientConfiguration(string apiKey, int retryAttempts)
        {
            this.ApiKey = apiKey;
            this.RetryAttempts = retryAttempts;
        }
        public TheSportsDBClientConfiguration(string apiKey, int retryAttempts, TimeSpan intervalBetweenAttempts)
        {
            this.ApiKey = apiKey;
            this.RetryAttempts = retryAttempts;
            this.IntervalBetweenAttempts = intervalBetweenAttempts;
        }
    }
}
