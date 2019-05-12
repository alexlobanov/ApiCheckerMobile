using Prism;
using Prism.Ioc;
using ApiChecker.ViewModels;
using ApiChecker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using ApiChecker.Services.Interfaces;
using System.Threading.Tasks;
using ApiChecker.Services;
using ApiChecker.Repository.Interfaces;
using ApiChecker.Repository;
using ApiChecker.Repository.Fake;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ApiChecker
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
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
            containerRegistry.Register<IRequestProvider, JsonRequestProvider>();
            containerRegistry.Register<ITutorialRepository, TutorialRepository>();
            containerRegistry.Register<IAppLogger, AppCenterLogger>();

#if DEBUG
            //containerRegistry.Register<ILatencyRepository, FakeLatencyRepository>();
            containerRegistry.Register<ILatencyRepository, LatencyRepository>();
#else
            containerRegistry.Register<ILatencyRepository, LatencyRepository>();
#endif
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<GlobalLatencyResultPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<GuidePage>();

        }
    }
}
