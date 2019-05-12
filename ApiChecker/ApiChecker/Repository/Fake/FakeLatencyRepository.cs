using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiChecker.Models;
using ApiChecker.Models.Enums;
using ApiChecker.Repository.Interfaces;

namespace ApiChecker.Repository.Fake
{
    public class FakeLatencyRepository : ILatencyRepository
    {
        public Task<GlobalLatencyModel> GetLatency(GlobalLatenctyRequestModel globalLatenctyRequest)
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
