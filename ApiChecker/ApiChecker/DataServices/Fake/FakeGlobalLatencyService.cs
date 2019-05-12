using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.Models;
using ApiChecker.Models.Enums;

namespace ApiChecker.DataServices.Fake
{
    public class FakeGlobalLatencyService : IGlobalLatencyService
    {
        public FakeGlobalLatencyService()
        {
        }

        public Task<GlobalLatencyModel> VeifyGlobalLatencyForService(GlobalLatenctyRequestModel globalLatenctyRequest)
        {
            return Task.FromResult(new GlobalLatencyModel()
            {
                Status = ServiceStatusEnum.WORKING,
                ElapsedTime = 12000,
                LocationsTested = new List<GlobalLocationModel>()
                {
                    new GlobalLocationModel()
                    {
                        Location = "Singapore",
                        Download = 20,
                        Tcp = 20,
                        Dns = 12,
                        FirstByte = 20,
                        ResponseCode = 200,
                        Status = true
                    }
                },
                Url = "https://apichecker.com"
            });
        }
    }
}
