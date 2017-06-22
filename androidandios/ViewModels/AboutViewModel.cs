// AboutViewModel.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace androidandios
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Plugin.Share.CrossShare.Current.OpenBrowser("https://xamarin.com/platform"));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }
}
