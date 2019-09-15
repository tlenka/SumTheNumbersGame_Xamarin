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
            //MainPage = new NavigationPage(new Views.MainPageView());
            NavigationService.Configure("MainPage", typeof(Views.MainPageView));
            NavigationService.Configure("GamePage", typeof(Views.GamePageView));
            NavigationService.Configure("TutorialPage", typeof(Views.TutorialPageView));

            var mainPage = ((NavigationService)NavigationService).SetRootPage("MainPage");

            MainPage = mainPage;

        }

        public static INavigationService NavigationService { get; } = new NavigationService();

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


    //[ContentProperty("Source")]
    //public class ImageResourceExtension : IMarkupExtension
    //{
    //    public string Source { get; set; }

    //    public object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        if (Source == null)
    //            return null;

    //        // Do your translation lookup here, using whatever method you require
    //        var imageSource = ImageSource.FromFile("back3.png");

    //        return imageSource;
    //    }
    //}
}
