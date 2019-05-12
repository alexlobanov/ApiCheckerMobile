using System;
namespace ApiChecker.Services.Interfaces
{
    public interface IKeyValueStorage
    {
        string Set(string key, string val);
        string Get(string key);
        string Remove(string key);
        void RemoveAll();
    }
}
