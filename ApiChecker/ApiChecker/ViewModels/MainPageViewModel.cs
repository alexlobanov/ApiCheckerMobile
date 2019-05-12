using ApiChecker.DataServices.Interfaces;
using ApiChecker.Helpers;
using ApiChecker.Models;
using ApiChecker.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand StartUrlScanningCommand { get; set; }
        public string UrlForScanning { get; set; }
        public bool IsBusy { get; set; }

        private readonly IGlobalLatencyService _globalLatencyService;

        public MainPageViewModel(INavigationService navigationService,
                                 IGlobalLatencyService globalLatencyService)
            : base(navigationService)
        {
            _globalLatencyService = globalLatencyService;
            StartUrlScanningCommand = new DelegateCommand(StartUrlScanning, () => !IsBusy)
                                     .ObservesProperty(() => IsBusy);
        }

        private async void StartUrlScanning()
        {
            IsBusy = true;
            var globalLatencyVerifierRequest = new GlobalLatenctyRequestModel(UrlForScanning);
            var latencyResult = await _globalLatencyService.VeifyGlobalLatencyForService(globalLatencyVerifierRequest);
            NavigateToResultPage(latencyResult);

        }

        private async void NavigateToResultPage(GlobalLatencyModel globalLatencyResult)
        {
            var navigationParameters = new NavigationParameters
            {
                { NavigationKeys.GlobalLatencyResultKey, globalLatencyResult }
            };
            await NavigationService.NavigateAsync(nameof(GlobalLatencyResultPage), navigationParameters);
        }

    }
}
