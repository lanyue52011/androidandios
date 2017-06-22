// LoginViewController.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using UIKit;

namespace androidandios.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewModel ViewModel;

        public LoginViewController(IntPtr handle) : base(handle)
        {
            ViewModel = new LoginViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.Title = ViewModel.Title;
        }

        partial void NotNowButton_TouchUpInside(UIButton sender) => NavigateToTabbed();

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            if (Settings.IsLoggedIn)
                NavigateToTabbed();
        }

        void NavigateToTabbed()
        {
            InvokeOnMainThread(() =>
                {
                    var app = (AppDelegate)UIApplication.SharedApplication.Delegate;
                    app.Window.RootViewController = UIStoryboard.FromName("Main", null)
                    .InstantiateViewController("tabViewController")
                    as UITabBarController;
                //var control =new ViewControllers.MyViewController();
                    //app.Window.RootViewController = control;
                });
        }
    }
}
