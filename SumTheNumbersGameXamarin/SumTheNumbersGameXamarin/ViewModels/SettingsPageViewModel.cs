using SumTheNumbersGameXamarin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumTheNumbersGameXamarin.ViewModels
{
    class SettingsPageViewModel : BaseViewModel
    {
        private readonly ISettings _settings;
        private int _count;
        private bool _check10;
        private bool _check100;
        private bool _check1000;

        private double _check10_Opacity;
        private double _check100_Opacity;
        private double _check1000_Opacity;

        private int _check10_BorderW;
        private int _check100_BorderW;
        private int _check1000_BorderW;

        private readonly double _checkedOpacity;
        private readonly double _uncheckedOpacity;

        private readonly int _checkedBorderW;
        private readonly int _uncheckedBorderW;

        public double Check10_Opacity
        {
            get { return _check10_Opacity; }
            set
            {
                if(_check10_Opacity != value)
                {
                    _check10_Opacity = value;
                    RaisePropertyChanged(nameof(Check10_Opacity));
                }
            }
        }

        public double Check100_Opacity
        {
            get { return _check100_Opacity; }
            set
            {
                if (_check100_Opacity != value)
                {
                    _check100_Opacity = value;
                    RaisePropertyChanged(nameof(Check100_Opacity));
                }
            }
        }

        public double Check1000_Opacity
        {
            get { return _check1000_Opacity; }
            set
            {
                if (_check1000_Opacity != value)
                {
                    _check1000_Opacity = value;
                    
                    RaisePropertyChanged(nameof(Check1000_Opacity));
                }
            }
        }

        public int Check10_BorderW
        {
            get { return _check10_BorderW; }
            set
            {
                if (_check10_BorderW != value)
                {
                    _check10_BorderW = value;
                    RaisePropertyChanged(nameof(Check10_BorderW));
                }
            }
        }
        public int Check100_BorderW
        {
            get { return _check100_BorderW; }
            set
            {
                if (_check100_BorderW != value)
                {
                    _check100_BorderW = value;
                    RaisePropertyChanged(nameof(Check100_BorderW));
                }
            }
        }
        public int Check1000_BorderW
        {
            get { return _check1000_BorderW; }
            set
            {
                if (_check1000_BorderW != value)
                {
                    _check1000_BorderW = value;
                    RaisePropertyChanged(nameof(Check1000_BorderW));
                }
            }
        }
        //public int checkBO;
        //public bool Check10
        //{
        //    get
        //    {
        //        return _check10;
        //    }
        //    set
        //    {
        //        if (_check10 != value)
        //        {
        //            _check10 = value;
        //            RaisePropertyChanged(nameof(Check10));
        //            _settings.Check10 = Check10;
        //        }
        //    }
        //}

        public int Count
        {
            get { return _count; }
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


        public SettingsPageViewModel()
        {
            CheckRangeCommand = new Command((x) =>  CheckRange(x.ToString()));
            _settings = App.GameSettings;
            _count = _settings.CountOfNumbers;

            _checkedOpacity = 1;
            _uncheckedOpacity = 0.5;

            _check10 = _settings.Check10;
            _check100 = _settings.Check100;
            _check1000 = _settings.Check1000;

            _check10_Opacity = CheckBoxOpacity(_check10);
            _check100_Opacity = CheckBoxOpacity(_check100);
            _check1000_Opacity = CheckBoxOpacity(_check1000);

            _check10_BorderW = CheckBoxBorderWidth(_check10);
            _check100_BorderW = CheckBoxBorderWidth(_check100);
            _check1000_BorderW = CheckBoxBorderWidth(_check1000);


        }

        public Command CheckRangeCommand { get; set; }

        private void CheckRange(string checkBox)
        {
            switch (checkBox)
            {
                case "10":
                    _check10 = !_check10;
                    Check10_Opacity = CheckBoxOpacity(_check10);
                    Check10_BorderW = CheckBoxBorderWidth(_check10);
                    _settings.Check10 = _check10;
                    break;
                case "100":
                    _check100 = !_check100;
                    Check100_Opacity = CheckBoxOpacity(_check100);
                    Check100_BorderW = CheckBoxBorderWidth(_check100);
                    _settings.Check100 = _check100;
                    break;
                case "1000":
                    _check1000 = !_check1000;
                    Check1000_Opacity = CheckBoxOpacity(_check1000);
                    Check1000_BorderW = CheckBoxBorderWidth(_check1000);
                    _settings.Check1000 = _check1000;
                    break;
                    
            }


           

        }

        private double CheckBoxOpacity(bool fullOpacity)
        {
            return fullOpacity ? 1 :  0.5;
        }

        private int CheckBoxBorderWidth(bool isChecked)
        {
            return isChecked ? 2 : 10;
        }


        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
