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

        //public SettingsModel()
        //{

        //    System.Diagnostics.Debug.WriteLine(Check100);

        //}

        public SettingsModel(int count = 10, bool check10 = true, bool check100 = false, bool check1000 = false)
        {
            CountOfNumbers = count;
            Check10 = check10;
            Check100 = check100;
            Check1000 = check1000;
        }

        //public SettingsModel(SettingsModel settings)
        //{
        //    CountOfNumbers = settings.CountOfNumbers;
        //    Check10 = settings.Check10;
        //    Check100 = settings.Check100;
        //    Check1000 = settings.Check1000;
        //}

        //public void SetDefaultValues()
        //{
        //    CountOfNumbers = 10;
        //    Check10 = true;
        //    Check100 = true;
        //    Check1000 = false;
        //}
    }
}
