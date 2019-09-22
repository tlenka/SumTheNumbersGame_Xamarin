using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SumTheNumbersGameXamarin.Service
{
    public interface INavigationService
    {
        string CurrentPageKey { get; }
        Task GoBack();
        void Configure(string pageKey, Type pageType);
        
        //Task GoBack();

        Task NavigateAsync(string pageKey, bool animated = true);
        Task NavigateAsync(string pageKey, object parameter, bool animated = true);

        Task NavigateModalAsync(string pageKey, bool animated = true);
        Task NavigateModalAsync(string pageKey, object parameter, bool animated = true);
    }
}
