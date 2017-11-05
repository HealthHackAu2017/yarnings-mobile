using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace Yarnings.Droid
{

    [Activity ( Label = "Yarnings", Icon = "@drawable/icon", Theme = "@style/MyTheme", 
               MainLauncher = true, 
               ConfigurationChanges = ConfigChanges.ScreenSize | 
               ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Landscape) ]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.RequestFeature(WindowFeatures.ActionBar);
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            Forms.SetTitleBarVisibility(AndroidTitleBarVisibility.Never);


            LoadApplication(new App());
        }
    }

}
