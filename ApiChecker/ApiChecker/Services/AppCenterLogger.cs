using System;
using System.Collections.Generic;
using Prism.Logging;
using ApiChecker.Services.Interfaces;

namespace ApiChecker.Services
{
    public class AppCenterLogger : IAppLogger
    {
        public AppCenterLogger()
        {
        }

        public void Debug(string message)
        {
            
        }

        public void Error(string errorMessage)
        {
            
        }

        public void Error(string errorMessage, Exception ex)
        {
            
        }

        public void Log(string message, Category category, Priority priority)
        {
            
        }

        public void Metric(string page, string feature, Dictionary<string, string> metrics = null)
        {
            
        }
    }
}
