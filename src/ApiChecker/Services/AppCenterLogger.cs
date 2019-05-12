using System;
using System.Collections.Generic;
using Prism.Logging;
using ApiChecker.Services.Interfaces;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

namespace ApiChecker.Services
{
    public class AppCenterLogger : IAppLogger
    {
        public void Debug(string message)
        {
            Analytics.TrackEvent(message);
        }

        public void Error(string errorMessage)
        {
            Analytics.TrackEvent(errorMessage);
        }

        public void Error(string errorMessage, Exception ex)
        {
            Crashes.TrackError(ex);
        }

        public void Log(string message, Category category, Priority priority)
        {
            Analytics.TrackEvent($"[{priority.ToString()} - {category.ToString()}: {message}");
        }

        public void Metric(string page, string feature, Dictionary<string, string> metrics = null)
        {
            Analytics.TrackEvent(page, metrics);
        }
    }
}
