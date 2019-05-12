using System;
using System.Threading.Tasks;
using ApiChecker.DataServices.Base;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.Exceptions;
using ApiChecker.Models;

namespace ApiChecker.DataServices
{
    public class GlobalLatencyService : IGlobalLatencyService
    {
        private readonly IRequestProvider _requestProvider;

        public GlobalLatencyService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<GlobalLatencyModel> VeifyGlobalLatencyForService(GlobalLatenctyRequest globalLatenctyRequest)
        {
            GlobalLatencyModel globalLatency = await _requestProvider.PostAsync<GlobalLatenctyRequest, GlobalLatencyModel>(GlobalSettings.ApiCheckerEndpoint, globalLatenctyRequest);
            if (globalLatency == null)
            {
                throw new GlobalLatencyFailedException("GlobalLatency not avalible for your service or you already reach request limit");
            }
            return globalLatency;
        }


    }
}
