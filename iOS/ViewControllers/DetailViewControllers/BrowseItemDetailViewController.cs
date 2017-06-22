// BrowseItemDetailViewController.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using UIKit;

namespace androidandios.iOS
{
    public partial class BrowseItemDetailViewController : UIViewController
    {
        public ItemDetailViewModel ViewModel { get; set; }
        public BrowseItemDetailViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = ViewModel.Title;
            ItemNameLabel.Text = ViewModel.Item.Text;
            ItemDescriptionLabel.Text = ViewModel.Item.Description;
        }
    }
}
