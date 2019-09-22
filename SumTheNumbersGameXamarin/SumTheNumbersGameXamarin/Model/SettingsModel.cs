using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.Model
{
    public class SettingsModel : ISettings
    {
        public int CountOfNumbers { get; set; }
        public int SpeedLevel { get; set; }

        public bool Check10 { get; set; }
        public bool Check100 { get; set; }
        public bool Check1000 { get; set; }

        public SettingsModel(int count = 5, bool check10 = true, bool check100 = false, bool check1000 = false, int speed = 2)
        {
            CountOfNumbers = count;
            Check10 = check10;
            Check100 = check100;
            Check1000 = check1000;
            SpeedLevel = speed;
        }
    }
}
