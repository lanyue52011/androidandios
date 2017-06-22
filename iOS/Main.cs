// Main.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using UIKit;

namespace androidandios.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
