using System;
using System.Threading.Tasks;
using ApiChecker.Exceptions;
using ApiChecker.Models;
using ApiChecker.Repository.Interfaces;
using ApiChecker.Services.Interfaces;

namespace ApiChecker.Repository
{
    public class LatencyRepository : ILatencyRepository
    {
        private readonly IRequestProvider _requestProvider;

        public LatencyRepository(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<GlobalLatencyModel> GetLatency(GlobalLatenctyRequestModel globalLatenctyRequest)
        {
            var globalLatency = await _requestProvider.PostAsync<GlobalLatenctyRequestModel, GlobalLatencyModel>(
                    GlobalSettings.ApiCheckerEndpoint, globalLatenctyRequest);

            if (globalLatency == null)
            {
                throw new GlobalLatencyFailedException("GlobalLatency not avalible for your service or you already reach request limit");
            }
            return globalLatency;
        }

    }
}
