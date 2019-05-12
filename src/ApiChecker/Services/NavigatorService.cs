using System;
using ApiChecker.Services.Interfaces;
using ApiChecker.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace ApiChecker.Services
{
    public class NavigatorService : INavigatorService
    {
        /// <summary>
        /// Method to handle initial navigation path on application start     
        /// </summary>
        /// <returns>The main page relative path.</returns>
        public string GetMainPagePath()
        {
            return nameof(GuidePage);

            if (Device.RuntimePlatform == Device.Android)
            {
                //per https://github.com/alexrainman/CarouselView/issues/501
                return nameof(NavigationPage) + "/" + nameof(MainPage);
            }

            if (Helpers.Settings.IsTutorialCompleted)
                return nameof(NavigationPage) + "/" + nameof(MainPage);
            else
                return nameof(GuidePage);
        }
    }
}
