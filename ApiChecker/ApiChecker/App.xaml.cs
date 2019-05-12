using Prism;
using Prism.Ioc;
using ApiChecker.ViewModels;
using ApiChecker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using ApiChecker.Services.Interfaces;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.DataServices.Base;
using ApiChecker.DataServices;
using System.Threading.Tasks;
using ApiChecker.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ApiChecker
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(GetMainNavigationPath());
        }

        private string GetMainNavigationPath()
        {
            var navigatorService = this.Container.Resolve<INavigatorService>();
            return navigatorService.GetMainPagePath();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<INavigatorService, NavigatorService>();
            containerRegistry.Register<ITutorialService, TutorialService>();
            containerRegistry.Register<IRequestProvider, JsonRequestProvider>();
            containerRegistry.Register<IGlobalLatencyService, GlobalLatencyService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<GuidePage>();

        }
    }
}
