﻿using SumTheNumbersGameXamarin.ViewModels;
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
	public partial class SettingsPageView : ContentPage
	{
		public SettingsPageView ()
		{
			InitializeComponent ();
            BindingContext = new SettingsPageViewModel();
		}
	}
}