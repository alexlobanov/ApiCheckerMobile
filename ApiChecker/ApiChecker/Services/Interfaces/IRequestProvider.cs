﻿using System;
using System.Threading.Tasks;

namespace ApiChecker.Services.Interfaces
{
    public interface IRequestProvider
    {
        Task<TResult> GetAsync<TResult>(string uri);

        Task<TResult> PostAsync<TResult>(string uri, TResult data);

        Task<TResult> PostAsync<TRequest, TResult>(string uri, TRequest data);

        Task<TResult> PutAsync<TResult>(string uri, TResult data);

        Task<TResult> PutAsync<TRequest, TResult>(string uri, TRequest data);
    }
}
