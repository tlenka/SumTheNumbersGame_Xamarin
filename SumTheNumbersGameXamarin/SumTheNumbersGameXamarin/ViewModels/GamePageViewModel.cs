using SumTheNumbersGameXamarin.Model;
using SumTheNumbersGameXamarin.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumTheNumbersGameXamarin.ViewModels
{
    class GamePageViewModel : BaseViewModel
    {
        private readonly ISettings _settings;
        private readonly INavigationService _navigationService;

        private readonly GameModel _newGame;

        private string _stringNumbers;
        private string _userAnswer;
        private bool _isCheckAnswerEnable;
        private bool _isPlayAgainEnable;
        private string _answerText;
        private string _numbersBackground;

        public string NumbersBackground
        {
            get { return _numbersBackground; }
            set
            {
                if (_numbersBackground != value)
                {
                    _numbersBackground = value;
                    RaisePropertyChanged(nameof(NumbersBackground));
                }
            }
        }

        public string AnswerText
        {
            get { return _answerText; }
            set
            {
                if(_answerText != value)
                {
                    _answerText = value;
                    RaisePropertyChanged(nameof(AnswerText));
                }
            }
        }

        public bool IsPlayAgainEnable
        {
            get { return _isPlayAgainEnable; }
            set
            {
                if(_isPlayAgainEnable != value)
                {
                    _isPlayAgainEnable = value;
                    RaisePropertyChanged(nameof(IsPlayAgainEnable));
                }
            }
        }

        public bool IsCheckAnswerEnable
        {
            get { return _isCheckAnswerEnable; }
            set
            {
                if(_isCheckAnswerEnable != value)
                {
                    _isCheckAnswerEnable = value;
                    RaisePropertyChanged(nameof(IsCheckAnswerEnable));
                }
            }
        }
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
            _navigationService = App.NavigationService;

            _newGame = new GameModel(_settings);

            // _numbers = new int[5] { count, 0, count, 0, count };
            //_isVisibleBtn = true;
            //_isCheckAnswerEnable = false;
            //_isPlayAgainEnable = true;
            //_answerText = "Are you ready? Click Start!";

            SetBeforeStartOptions();
            StartCountCommand = new Command(x => StartTheGame());
            PlayAgainCommand = new Command(x => PlayAgain());
            //CheckTheAnswerCommand = new Command(x => CheckTheAnswer(x.ToString()));
            CheckTheAnswerCommand = new Command(x => CheckTheAnswer());
            GoBackCommand = new Command(x => GoBack());
            //StartText = "Are you ready?";
            //StartTheGame();


            //System.Diagnostics.Debug.WriteLine(_newGame.Check100);

        }

        public Command StartCountCommand { get; set; }
        private async void StartTheGame()
        {
            IsVisibleBtn = false;
            IsPlayAgainEnable = false;
            AnswerText = "";
            var randomNumbers = _newGame.RandomNumbers();

            await Task.Delay(1000);
            foreach (int num in randomNumbers)
            {
                StringNumbers = num.ToString();
                await Task.Delay(1000);
            }
            StringNumbers = "...";

            
            IsCheckAnswerEnable = true;
            IsPlayAgainEnable = true;
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
        
        private void CheckTheAnswer()
        {
            System.Diagnostics.Debug.WriteLine(IsCheckAnswerEnable);
            if (CanParseToInt(UserAnswer))
            {
                if (Convert.ToInt32(UserAnswer) == _newGame.SumOfNumbers)
                {
                    StringNumbers = _newGame.SumOfNumbers.ToString();
                    AnswerText = "Great! It's correct answer!";
                    NumbersBackground = "#80ff80";
                }
                else
                {
                    StringNumbers = _newGame.SumOfNumbers.ToString();
                    AnswerText = "Wrong! The correct answer is: ";
                    NumbersBackground = "#ffb3b3";
                }
            }
            else
            {
                StringNumbers = _newGame.SumOfNumbers.ToString();
                AnswerText = "Wrong! The correct answer is: ";
                NumbersBackground = "#ffb3b3";
            }

            IsCheckAnswerEnable = false;
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

        private void SetBeforeStartOptions()
        {
            IsVisibleBtn = true;
            IsCheckAnswerEnable = false;
            StringNumbers = "";
            UserAnswer = "";
            AnswerText = "Are you ready? Click Start!";
            NumbersBackground = "#e6f5ff";

        }

        public Command PlayAgainCommand { get; set; }
        private  void PlayAgain()
        {
             SetBeforeStartOptions();
        }

        public Command GoBackCommand { get; }
        private async void GoBack()
        {
            await _navigationService.GoBack();
        }

        
    }
}
