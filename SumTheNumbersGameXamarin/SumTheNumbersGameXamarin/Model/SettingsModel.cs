using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.Model
{
    public class SettingsModel : ISettings
    {
        public int CountOfNumbers { get; set; }
        public bool Check10 { get; set; }
        public bool Check100 { get; set; }
        public bool Check1000 { get; set; }


        public SettingsModel()
        {
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            CountOfNumbers = 10;
            Check10 = true;
            Check100 = false;
            Check1000 = false;
        }
    }
}
