using System;
using ApiChecker.Services.Interfaces;
using ApiChecker.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace ApiChecker.Services
{
    public class NavigatorService : INavigatorService
    {
        public NavigatorService()
        {
        }

        /// <summary>
        /// Method to handle first page once application started
        /// </summary>
        /// <returns>The main page relative path.</returns>
        public string GetMainPagePath()
        {
            if (Helpers.Settings.IsTutorialCompleted)
                return nameof(NavigationPage) + "/" + nameof(MainPage);
            else
                return nameof(GuidePage);
        }
    }
}
