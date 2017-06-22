// SplashActivity.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;

namespace androidandios.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/SplashTheme", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Intent newIntent;
            if (Settings.IsLoggedIn)
                newIntent = new Intent(this, typeof(MainActivity));
            else
                newIntent = new Intent(this, typeof(LoginActivity));

            newIntent.AddFlags(ActivityFlags.ClearTop);
            newIntent.AddFlags(ActivityFlags.SingleTop);
            StartActivity(newIntent);
            Finish();
        }
    }
}
