using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Polly;
using System.Threading.Tasks;

namespace TheSportsDB
{
    internal class RequestBuilder
    {
        public string Url { get; } = "https://www.thesportsdb.com/api";
        public string Version { get; } = "v1";
        public string APIKey { get; private set; }
        public string Endpoint { get; private set; }
        public Dictionary<string, string> Parameters { get; set; }
        public int MaxRetryAttempts { get; private set; } = 1;
        public TimeSpan PauseBetweenFailures { get; private set; } = TimeSpan.FromSeconds(2);


        public RequestBuilder(string apiKey)
        {
            this.APIKey = apiKey;
        }

        public RequestBuilder(string apiKey, int maxRetryAttempts)
        {
            this.APIKey = apiKey;
            this.MaxRetryAttempts = maxRetryAttempts;
        }

        public RequestBuilder(string apiKey, int maxRetryAttempts, TimeSpan pauseBetweenFailures)
        {
            this.APIKey = apiKey;
            this.MaxRetryAttempts = maxRetryAttempts;
            this.PauseBetweenFailures = pauseBetweenFailures;
        }

        public async Task<dynamic> Request(string endpoint, Dictionary<string,string> parameters)
        {
            this.Endpoint = endpoint;
            this.SetParameters(parameters);
            dynamic requestResult = null;

            var uri = GetURL();

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            var retryPolicy = Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(this.MaxRetryAttempts, i => this.PauseBetweenFailures);

            await retryPolicy.ExecuteAsync(async () =>
            {
                using var response = await request.GetRequestStreamAsync();
                using var reader = new StreamReader(response);
                var json = reader.ReadToEnd();
                requestResult = JObject.Parse(json);
            });

            return requestResult;
        }

        private string GetURL()
        {
            var uri = $"{this.Url}/{this.Version}/json/{this.APIKey}/{this.Endpoint}";
            return QueryHelpers.AddQueryString(uri, this.Parameters);
        }

        private void SetParameters(Dictionary<string, string> parameters)
        {
            this.Parameters = new Dictionary<string, string>();

            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    var value = HttpUtility.UrlEncode(item.Value).ToString();

                    this.Parameters.Add(item.Key, value);
                }
            }
        }
    }
}
