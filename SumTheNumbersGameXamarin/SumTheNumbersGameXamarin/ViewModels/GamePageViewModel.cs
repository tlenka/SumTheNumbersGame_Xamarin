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

        private readonly GameModel _newGame;

        //private int[] _numbers;
        private string _stringNumbers;
        private string _userAnswer;
        //private bool _IsCorrectAnswer;

        public string UserAnswer
        {
            get { return _userAnswer; }
            set
            {
                if (_userAnswer != value)
                {
                    _userAnswer = value;
                    RaisePropertyChanged(nameof(UserAnswer));
                }
            }
        }

        public string StringNumbers
        {
            get { return _stringNumbers; }
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
            get { return _isVisibleBtn; }
            set
            {
                if(_isVisibleBtn != value)
                {
                    _isVisibleBtn = value;
                    RaisePropertyChanged(nameof(IsVisibleBtn));
                }
            }
        }


        public GamePageViewModel()
        {
            _settings = App.GameSettings;
            //int count = _settings.CountOfNumbers;

            _newGame = new GameModel(_settings);

            // _numbers = new int[5] { count, 0, count, 0, count };
            _isVisibleBtn = true;

            StartCountCommand = new Command(x => StartTheGame());
            PlayAgainCommand = new Command(x => PlayAgain());
            CheckTheAnswerCommand = new Command(x => CheckTheAnswer(x.ToString()));
            //StartText = "Are you ready?";
            //StartTheGame();
           

            //System.Diagnostics.Debug.WriteLine(_newGame.Check100);

        }

        private Random rand;

        public Command StartCountCommand { get; set; }
        private async void StartTheGame()
        {
            IsVisibleBtn = false;

            var randomNumbers = _newGame.RandomNumbers();

            await Task.Delay(1000);
            foreach (int num in randomNumbers)
            {
                StringNumbers = num.ToString();
                await Task.Delay(1000);
            }
            StringNumbers = "...";
            //foreach(int num in _numbers)
            //{
            //    num = rand.Next(0; 10);
            //    StringNumbers = num.ToString();
            //    await Task.Delay(1000);
            //}


            //StringNumbers = _settings.CountOfNumbers.ToString();
            //await Task.Delay(1000);
            //StringNumbers = _settings.CountOfNumbers.ToString();
            //await Task.Delay(1000);
            //StringNumbers = _settings.CountOfNumbers.ToString();


        }

        public Command CheckTheAnswerCommand { get; set; }
        private void CheckTheAnswer(string userAnswer)
        {

            if (CanParseToInt(userAnswer))
            {
                if (Convert.ToInt32(userAnswer) == _newGame.SumOfNumbers)
                    StringNumbers = "Good" + _newGame.SumOfNumbers.ToString();
                else
                    StringNumbers = "Wrong!" + _newGame.SumOfNumbers.ToString();
            }
            else
            {
                StringNumbers = "Wrong!" + _newGame.SumOfNumbers.ToString();
            }
        }

        private bool CanParseToInt(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch (FormatException fe)
            {
                return false;
            }
            
        }

        public Command PlayAgainCommand { get; set; }
        private void PlayAgain()
        {
            IsVisibleBtn = true;
            StringNumbers = "";
            UserAnswer = "";
            
        }





    }
}
