using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.Model
{
    public interface ISettings
    {
        int CountOfNumbers { get; set; }
        bool Check10 { get; set; }
        bool Check100 { get; set; }
        bool Check1000 { get; set; }
    }
}
