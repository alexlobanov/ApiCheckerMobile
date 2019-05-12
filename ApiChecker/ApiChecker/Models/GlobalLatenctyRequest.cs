using System;
namespace ApiChecker.Models
{
    public class GlobalLatenctyRequest
    {
        public Uri Uri { get; set; }

        public GlobalLatenctyRequest()
        {

        }

        public GlobalLatenctyRequest(string url)
        {
            Uri = new Uri(url);
        }

        public GlobalLatenctyRequest(Uri uri)
        {
            Uri = uri;
        }

        public override string ToString()
        {
            return Uri?.ToString();
        }

    }
}
