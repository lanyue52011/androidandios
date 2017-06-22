// BaseActivity.cs
// Author:tab <lanyue52011@163.com>
// 4/27/2017 
//
//
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace androidandios.Droid
{
    public class BaseActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(LayoutResource);
            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            if (Toolbar != null)
            {
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetHomeButtonEnabled(true);

            }
        }

        public Toolbar Toolbar
        {
            get;
            set;
        }

        protected virtual int LayoutResource
        {
            get;
        }

        protected int ActionBarIcon
        {
            set { Toolbar?.SetNavigationIcon(value); }
        }
    }
}
