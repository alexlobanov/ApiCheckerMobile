using System;
namespace ApiChecker.Exceptions
{
    public class GlobalLatencyFailedException : Exception
    {
        public string Content { get; }

        public GlobalLatencyFailedException()
        {
        }

        public GlobalLatencyFailedException(string content)
        {
            Content = content;
        }
    }
}
