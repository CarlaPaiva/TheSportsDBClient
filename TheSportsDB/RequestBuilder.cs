using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;

namespace TheSportsDB
{
    internal class RequestBuilder
    {
        public string Url { get; } = "https://www.thesportsdb.com/api";
        public string Version { get; } = "v1";
        public string APIKey { get; private set; }
        public string Endpoint { get; private set; }
        public Dictionary<string, string> Parameters { get; set; }
        public RequestBuilder(string apiKey)
        {
            this.APIKey = apiKey;
        }

        public dynamic Request(string endpoint, Dictionary<string,string> parameters)
        {
            this.Endpoint = endpoint;
            this.SetParameters(parameters);

            var uri = GetURL();

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                return JObject.Parse(json);
            }
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
