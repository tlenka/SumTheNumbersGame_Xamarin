using SumTheNumbersGameXamarin.Model;
using SumTheNumbersGameXamarin.Service;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SumTheNumbersGameXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationService.Configure("MainPage", typeof(Views.MainPageView));
            NavigationService.Configure("GamePage", typeof(Views.GamePageView));
            NavigationService.Configure("TutorialPage", typeof(Views.TutorialPageView));
            NavigationService.Configure("SettingsPage", typeof(Views.SettingsPageView));

            var mainPage = ((NavigationService)NavigationService).SetRootPage("MainPage");
            MainPage = mainPage;
        }

        public static INavigationService NavigationService { get; } = new NavigationService();
        public static ISettings GameSettings { get; } = new SettingsModel();

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
