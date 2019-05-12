using System;
using ApiChecker.Helpers;

namespace ApiChecker
{
    public static class GlobalSettings
    {
        public const string ApiCheckerEndpoint = "https://api.apichecker.com/v1/public/check";

        /// <summary>
        /// Secrets should be configurable with secrets.json and Secrets class first
        /// </summary>
        public static string AppCenterStart
        {
            get
            {
                string startup = string.Empty;
#if DEBUG
#else
                if (Guid.TryParse(Secrets.AppCenter_iOS_Secret, out Guid iOSSecret))
                {
                    startup += $"ios={iOSSecret};";
                }

                if (Guid.TryParse(Secrets.AppCenter_Android_Secret, out Guid AndroidSecret))
                {
                    startup += $"android={AndroidSecret};";
                }
#endif
                return startup;
            }
        }
    }
}
