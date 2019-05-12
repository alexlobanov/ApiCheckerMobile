using System;
using System.Collections.Generic;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.Helpers;
using ApiChecker.Models;
using ApiChecker.Views;
using Prism.Commands;
using Prism.Navigation;
using PropertyChanged;
using Xamarin.Forms;

namespace ApiChecker.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GuidePageViewModel : ViewModelBase
    {
        public List<TutorialItemModel> TutorialGuides { get; set; }
        public DelegateCommand CloseGuideCommand { get; set; }

        private readonly ITutorialService _tutorialService;

        public GuidePageViewModel(INavigationService navigationService,
                                  ITutorialService tutorialService) :
            base(navigationService)
        {
            _tutorialService = tutorialService;
            TutorialGuides = new List<TutorialItemModel>();
            CloseGuideCommand = new DelegateCommand(CloseCommandAction);
        }

        public void CloseCommandAction()
        {
            Settings.IsTutorialCompleted = true;
            NavigationService.NavigateAsync(nameof(MainPage));
        }


        public override void OnNavigatingTo(INavigationParameters parameters)
		{
            base.OnNavigatingTo(parameters);
            TutorialGuides = new List<TutorialItemModel>(_tutorialService.GetTutorialGuides());
		}
	}
}
