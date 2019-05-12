using System;
using Newtonsoft.Json;

namespace ApiChecker.Models
{
    public class GlobalLatenctyRequestModel
    {
        [JsonProperty("url")]
        public Uri RequestUrl { get; set; }

        public GlobalLatenctyRequestModel() { }

        public GlobalLatenctyRequestModel(string url)
        {
            RequestUrl = new Uri(url);
        }

        public GlobalLatenctyRequestModel(Uri uri)
        {
            RequestUrl = uri;
        }

        public override string ToString()
        {
            return RequestUrl?.ToString();
        }

    }
}
