using SumTheNumbersGameXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SumTheNumbersGameXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageView : ContentPage
	{

        //public static string Tet { get; set; }

        

        public MainPageView ()
		{

            InitializeComponent();
            BindingContext = new MainPageViewModel();
            
            //var image = new Image();
            //image.Source = ImageSource.FromResource("SumTheNumbersGameXamarin.Resource.background_orange.jpg");

        }

        
    }

}