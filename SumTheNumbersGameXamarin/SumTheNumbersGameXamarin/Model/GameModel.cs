using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.Model
{
    class GameModel : ISettings
    {
        private SettingsModel _settings;
        private Stack<int> _possibleNumbersStack;

        public int CountOfNumbers { get; set; }
        public bool Check10 { get; set; }
        public bool Check100 { get; set; }
        public bool Check1000 { get; set; }

        public GameModel(ISettings settings)
        {
            CountOfNumbers = settings.CountOfNumbers;
            Check10 = settings.Check10;
            Check100 = settings.Check100;
            Check1000 = settings.Check1000;
            _possibleNumbersStack = PreparePossibleNumbers();
        }

        private Stack<int> PreparePossibleNumbers()
        {
            var _possibleNumbersStack = new Stack<int>();

            if (Check10)
            {
                for(int i = 1; i < 10; i++)
                {
                    _possibleNumbersStack.Push(i);
                }
            }
            if (Check100)
            {
                for (int i = 10; i < 100; i++)
                {
                    _possibleNumbersStack.Push(i);
                }
            }
            if (Check1000)
            {
                for (int i = 101; i < 1000; i++)
                {
                    _possibleNumbersStack.Push(i);
                }
            }

             return _possibleNumbersStack;
        }

        public Array RandomNumbers()
        {
            var possibleNumbersArray = _possibleNumbersStack.ToArray();
            var randomNumbersArray = new int[CountOfNumbers];
            var randomIndex = 0;

            for(int i = 0; i < randomNumbersArray.Length; i++)
            {
                Random rand = new Random();
                randomIndex = rand.Next(0, possibleNumbersArray.Length);
                randomNumbersArray[i] = possibleNumbersArray[randomIndex];
            }
            return randomNumbersArray;
        }

    }
}
