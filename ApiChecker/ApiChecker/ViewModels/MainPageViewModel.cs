using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel : ViewModelBase
    {
        public string UrlForScanning { get; set; }
        public DelegateCommand StartUrlScanningCommand { get; set; }
        public bool IsBusy { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            StartUrlScanningCommand = new DelegateCommand(StartUrlScanning);
        }

        private void StartUrlScanning()
        {

        }

    }
}
