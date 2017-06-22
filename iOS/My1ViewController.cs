// My1ViewController.cs
//
// Author:tab <lanyue52011@163.com>
//
// Create 4/28/2017 2:21 PM
using System;

using UIKit;

namespace androidandios.iOS
{
    public partial class My1ViewController : UIViewController
    {
        public My1ViewController() : base("My1ViewController", null)
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

