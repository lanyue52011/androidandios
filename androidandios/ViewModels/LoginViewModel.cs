﻿// LoginViewModel.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System.Threading.Tasks;
using System.Windows.Input;

namespace androidandios
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            Title = "Login";
        }

        string message = string.Empty;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }

        public ICommand NotNowCommand { get; }
        public ICommand SignInCommand { get; }

        public async Task SignIn()
        {
            try
            {
                IsBusy = true;
                Message = "Signing In...";

                // Log the user in
                await TryLoginAsync();
            }
            finally
            {
                Message = string.Empty;
                IsBusy = false;

            }
        }


        public static async Task<bool> TryLoginAsync()
        {
            return true;
        }
    }
}
