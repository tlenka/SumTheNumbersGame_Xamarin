using SumTheNumbersGameXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumTheNumbersGameXamarin.ViewModels
{
    class GamePageViewModel : BaseViewModel
    {
        //private SettingsModel _settings;
        private readonly ISettings _settings;


        private int[] _numbers;
        private string _stringNumbers;

        public string StringNumbers
        {
            get
            {
                return _stringNumbers;
            }
            set
            {
                if (_stringNumbers != value)
                {
                    _stringNumbers = value;
                    RaisePropertyChanged(nameof(StringNumbers));
                }
            }
        }

        private bool _isVisibleBtn;
        public bool IsVisibleBtn
        {
            get
            {
                return _isVisibleBtn;
            }
            set
            {
                if(_isVisibleBtn != value)
                {
                    _isVisibleBtn = value;
                    RaisePropertyChanged(nameof(IsVisibleBtn));
                }
            }
        }

        public Command StartCountCommand { get; set; }
        public Command PlayAgainCommand { get; set; }

        public GamePageViewModel()
        {
            _settings = App.GameSettings;
            int count = _settings.CountOfNumbers;
            _numbers = new int[5] { count, 0, count, 0, count };
            IsVisibleBtn = true;
            StartCountCommand = new Command(x => StartTheGame());
            PlayAgainCommand = new Command(x => PlayAgain());
            rand = new Random();
            //StartText = "Are you ready?";
            //StartTheGame();
        }

        private Random rand;
        private async void StartTheGame()
        {
            IsVisibleBtn = false;

            await Task.Delay(1000);

            //foreach(int num in _numbers)
            //{
            //    num = rand.Next(0; 10);
            //    StringNumbers = num.ToString();
            //    await Task.Delay(1000);
            //}


            StringNumbers = _settings.CountOfNumbers.ToString();
            await Task.Delay(1000);
            StringNumbers = _settings.CountOfNumbers.ToString();
            await Task.Delay(1000);
            StringNumbers = _settings.CountOfNumbers.ToString();


        }

        private void PlayAgain()
        {
            IsVisibleBtn = true;
            StringNumbers = "";
            
        }





    }
}
