using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Polly;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Entities;

[assembly: InternalsVisibleTo("TheSportsDbTests")]

namespace TheSportsDB
{
    internal class RequestBuilder
    {
        public Dictionary<string, string> Parameters { get; set; }
        public string Endpoint { get; private set; }
        public string Url { get; } = "https://www.thesportsdb.com/api";
        public string Version { get; } = "v1";
        private readonly TheSportsDBClientConfiguration Configuration;

        public RequestBuilder(TheSportsDBClientConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public async Task<JObject> Request(string endpoint, Dictionary<string,string> parameters)
        {
            JObject requestResult = null;

            try
            {
                this.Endpoint = endpoint;
                this.SetParameters(parameters);

                var uri = GetURL();

                var retryPolicy = Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(this.Configuration.RetryAttempts, i => this.Configuration.IntervalBetweenAttempts);

                await retryPolicy.ExecuteAsync(async () =>
                {
                    var request = (HttpWebRequest)WebRequest.Create(uri);
                    request.AutomaticDecompression = DecompressionMethods.GZip;

                    using var response = request.GetResponse();
                    using var respStream = response.GetResponseStream();
                    using var reader = new StreamReader(respStream);
                    var json = reader.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                        requestResult = JObject.Parse(json);
                });

                return requestResult;
            }
            catch (Exception ex)
            {
                return requestResult;
            }
        }

        private string GetURL()
        {
            var uri = $"{this.Url}/{this.Version}/json/{this.Configuration.ApiKey}/{this.Endpoint}";
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
