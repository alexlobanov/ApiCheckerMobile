using System;
namespace ApiChecker.Services.Interfaces
{
    public interface INavigatorService
    {
        /// <summary>
        /// Method to handle initial navigation path on application start
        /// </summary>
        /// <returns>The main page relative path</returns>
        string GetMainPagePath();
    }
}
