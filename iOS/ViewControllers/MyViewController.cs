// MyViewController.cs
//
// Author:tab <lanyue52011@163.com>
//
// Create 4/28/2017 11:06 AM
using System;

using UIKit;

namespace androidandios.iOS.ViewControllers
{
    public partial class MyViewController : UIViewController
    {
        public MyViewController() : base("MyViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

