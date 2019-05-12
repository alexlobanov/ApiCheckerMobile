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
                        ResponseCode = 200,
                        Status = true
                    },
                    new GlobalLocationModel()
                    {
                        Location = "London",
                        Download = 25,
                        Tcp = 24,
                        Dns = 15,
                        ResponseCode = 202,
                        Status = true
                    }
                },
                Url = "https://apichecker.com"
            });
        }
    }
}
