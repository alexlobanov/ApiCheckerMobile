using System;
using System.Collections.Generic;
using ApiChecker.Models.Enums;

namespace ApiChecker.Models
{
    public class GlobalLatencyModel
    {
        public float ElapsedTime { get; set; }

        public ServiceStatusEnum Status { get; set; }

        public string Url { get; set; }

        public IList<GlobalLocationModel> LocationsTested { get; set; }
    }
}
