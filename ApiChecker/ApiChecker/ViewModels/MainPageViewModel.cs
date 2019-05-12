using ApiChecker.Exceptions;
using ApiChecker.Helpers;
using ApiChecker.Models;
using ApiChecker.Repository.Interfaces;
using ApiChecker.Services.Interfaces;
using ApiChecker.Validations;
using ApiChecker.Views;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using PropertyChanged;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand StartUrlScanningCommand { get; set; }
        public DelegateCommand ValidateUrlCommand { get; set; }

        public ValidatableObject<string> UrlForScanning { get; set; }
        public bool IsBusy { get; set; }

        private readonly ILatencyRepository _latencyRepository;
        private readonly IPageDialogService _pageDialogService;
        private readonly IAppLogger _appLogger;

        public MainPageViewModel(INavigationService navigationService,
                                 IPageDialogService pageDialogService,
                                 IAppLogger appLogger,
                                 ILatencyRepository globalLatencyService)
                                : base(navigationService)
        {
            _latencyRepository = globalLatencyService;
            _pageDialogService = pageDialogService;
            _appLogger = appLogger;

            InitValidationRules();

            StartUrlScanningCommand = new DelegateCommand(StartUrlScanning, IsAbleToSubmitRequest)
                                     .ObservesProperty(() => IsBusy)
                                     .ObservesProperty(() => UrlForScanning.IsValid);
            ValidateUrlCommand = new DelegateCommand(() => ValidateUrl());
        }


        private async void StartUrlScanning()
        {
            IsBusy = true;
            try
            {
                var globalLatencyVerifierRequest = new GlobalLatenctyRequestModel(UrlForScanning.Value);
                var latencyResult = await _latencyRepository.GetLatency(globalLatencyVerifierRequest);
                NavigateToResultPage(latencyResult);
            }
            catch (GlobalLatencyFailedException ex)
            {
                _appLogger.Error(nameof(GlobalLatencyFailedException), ex);
                await _pageDialogService.DisplayAlertAsync("Error", "You probably reach your request limit for this URL or our service is unavalible", "OK");
            }
            catch (ServiceAuthenticationException ex)
            {
                _appLogger.Error(nameof(GlobalLatencyFailedException), ex);
                await _pageDialogService.DisplayAlertAsync("Error", "You don't have access to this feature", "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async void NavigateToResultPage(GlobalLatencyModel globalLatencyResult)
        {
            var navigationParameters = new NavigationParameters
            {
                { NavigationKeys.GlobalLatencyResultKey, globalLatencyResult }
            };
            await NavigationService.NavigateAsync(nameof(GlobalLatencyResultPage), navigationParameters);
        }

        private bool IsAbleToSubmitRequest()
        {
            return !IsBusy && ValidateUrl();
        }

        private bool ValidateUrl()
        {
            return UrlForScanning.Validate();
        }


        private void InitValidationRules()
        {
            UrlForScanning = new ValidatableObject<string>();
            UrlForScanning.Validations.Add(new IsValidUrlRule() { ValidationMessage = "Please enter valid URL" });
        }

    }
}
