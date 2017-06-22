// RecyclerClickEvent.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;
using Android.Views;

namespace androidandios.Droid
{
    public class RecyclerClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}
