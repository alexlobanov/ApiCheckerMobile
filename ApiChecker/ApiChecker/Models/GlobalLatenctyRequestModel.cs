using System;
using Newtonsoft.Json;

namespace ApiChecker.Models
{
    public class GlobalLatenctyRequestModel
    {
        [JsonProperty("url")]
        public Uri Uri { get; set; }

        public GlobalLatenctyRequestModel()
        {

        }

        public GlobalLatenctyRequestModel(string url)
        {
            Uri = new Uri(url);
        }

        public GlobalLatenctyRequestModel(Uri uri)
        {
            Uri = uri;
        }

        public override string ToString()
        {
            return Uri?.ToString();
        }

    }
}
