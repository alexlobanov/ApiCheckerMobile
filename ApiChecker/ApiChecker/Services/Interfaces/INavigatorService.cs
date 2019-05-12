using System;
namespace ApiChecker.Services.Interfaces
{
    public interface INavigatorService
    {
        /// <summary>
        /// Method to handle navigation login on application start
        /// </summary>
        /// <returns>The main page relative path</returns>
        string GetMainPagePath();
    }
}
