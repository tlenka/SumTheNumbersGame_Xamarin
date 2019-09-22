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
	public partial class GamePageView : ContentPage
	{
		public GamePageView ()
		{
			InitializeComponent ();
            BindingContext = new GamePageViewModel();
        }
    }
}