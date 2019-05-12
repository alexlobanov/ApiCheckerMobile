using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiChecker.Models;

namespace ApiChecker.Repository.Interfaces
{
    public interface ILatencyRepository
    {
        Task<GlobalLatencyModel> GetLatency(GlobalLatenctyRequestModel globalLatenctyRequest);
    }
}
