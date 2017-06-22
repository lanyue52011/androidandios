// Utils.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using System;

using Foundation;
using UIKit;

namespace androidandios.iOS
{
    public static class Utils
    {
        public static NSObject Invoker;
        /// <summary>
        /// Ensures the invoked on main thread.
        /// </summary>
        /// <param name="action">Action to run on main thread.</param>
        public static void EnsureInvokedOnMainThread(Action action)
        {
            if (NSThread.Current.IsMainThread)
            {
                action();
                return;
            }
            if (Invoker == null)
                Invoker = new NSObject();

            Invoker.BeginInvokeOnMainThread(action);
        }

        public static bool IsPhone =>
            UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;

        public static bool IsTall =>
            IsPhone && (UIScreen.MainScreen.Bounds.Height * UIScreen.MainScreen.Scale >= 1136);
    }
}
