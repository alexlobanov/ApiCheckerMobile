using System;
using System.Collections.Generic;
using FFImageLoading.Helpers;
using Prism.Logging;

namespace ApiChecker.Services.Interfaces
{
    public interface IAppLogger : ILoggerFacade, IMiniLogger
    {
        void Metric(string page, string feature, Dictionary<string, string> metrics = null);
    }
}
