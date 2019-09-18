﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.Model
{
    public class SettingsModel : ISettings
    {
        public int CountOfNumbers { get; set; }

        public SettingsModel(int countOfNumbers = 10)
        {
            CountOfNumbers = countOfNumbers;
        }
    }
}
