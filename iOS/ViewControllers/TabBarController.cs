// TabBarController.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using UIKit;

namespace androidandios.iOS
{
    public partial class TabBarController : UITabBarController
    {
        public TabBarController(IntPtr handle) : base(handle)
        {
            TabBar.Items[0].Title = "Browse";
            TabBar.Items[1].Title = "About";
            TabBar.Items[2].Title = "My1";
        }
    }
}
