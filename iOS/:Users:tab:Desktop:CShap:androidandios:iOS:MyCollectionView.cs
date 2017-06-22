// MyCollectionViewCell.cs
//
// Author:tab <lanyue52011@163.com>
//
// Create 4/28/2017 1:52 PM
using System;

using Foundation;
using UIKit;

namespace androidandios.iOS
{
    public partial class MyCollectionView : UITableView
    {
        public static readonly NSString Key = new NSString("MyCollectionViewCell");
        public static readonly UINib Nib;

        static MyCollectionView()
        {
            Nib = UINib.FromName("MyCollectionViewCell", NSBundle.MainBundle);
        }

        protected MyCollectionView(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
