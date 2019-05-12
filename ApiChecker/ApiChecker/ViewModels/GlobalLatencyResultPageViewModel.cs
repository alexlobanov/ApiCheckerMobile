using System;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.Helpers;
using ApiChecker.Models;
using Prism.Navigation;
using PropertyChanged;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GlobalLatencyResultPageViewModel : ViewModelBase
    {
        public GlobalLatencyModel LatencyResult { get; set; }

        public GlobalLatencyResultPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {

        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            if (parameters.ContainsKey(NavigationKeys.GlobalLatencyResultKey))
            {
                LatencyResult = parameters.GetValue<GlobalLatencyModel>(NavigationKeys.GlobalLatencyResultKey);
            }
        }

    }
}
