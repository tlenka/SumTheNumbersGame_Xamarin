using SumTheNumbersGameXamarin.Model;
using SumTheNumbersGameXamarin.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumTheNumbersGameXamarin.ViewModels
{
    class MainPageViewModel
    {
        private readonly INavigationService _navigationService;

        public string Tekst { get; set; }
        public Command NavigationCommand { get; set; }
        public Command ExitCommand { get; set; }

        public MainPageViewModel()
        {
            _navigationService = App.NavigationService;
            NavigationCommand = new Command(async (x) => await NavigateTo(x.ToString()));
        }

        private async Task NavigateTo(string pageType)
        {
            await _navigationService.NavigateAsync(pageType);
        }
    }
}
