using System;
using System.Threading.Tasks;
using ApiChecker.Models;

namespace ApiChecker.DataServices.Interfaces
{
    public interface IGlobalLatencyService
    {
        Task<GlobalLatencyModel> VeifyGlobalLatencyForService(GlobalLatenctyRequestModel globalLatenctyRequest);
    }
}
