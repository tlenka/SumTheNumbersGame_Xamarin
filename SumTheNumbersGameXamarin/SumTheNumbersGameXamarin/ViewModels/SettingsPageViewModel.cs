using SumTheNumbersGameXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumTheNumbersGameXamarin.ViewModels
{
    class SettingsPageViewModel : BaseViewModel
    {
        private readonly ISettings _settings;
        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    RaisePropertyChanged(nameof(Count));
                    _settings.CountOfNumbers = Count;
                }
            }
        }

        
       
        //public SettingsModel Settings
        //{
        //    get
        //    {
        //        return _settings;
        //    }
        //    set
        //    {
        //        if (_settings != value)
        //        {
        //            _settings = value;
        //            RaisePropertyChanged(nameof(Settings));
        //        }
        //    }
        //}


        public SettingsPageViewModel()
        {
            _settings = App.GameSettings;
            _count = _settings.CountOfNumbers;
           // System.Diagnostics.Debug.WriteLine(_settings.CountOfNumbers);
            //_settings = settings;
            //_settings.CountOfNumbers = 8;
        }
    }
}
