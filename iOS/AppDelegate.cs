using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Yarnings.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            if (Xamarin.Forms.Application.Current == null || Xamarin.Forms.Application.Current.MainPage == null)
            {
                return UIInterfaceOrientationMask.Landscape;
            }

            var mainPage = Xamarin.Forms.Application.Current.MainPage;

            if (mainPage is YarningsWebPage)
            {
                return UIInterfaceOrientationMask.Landscape;
            }

            return UIInterfaceOrientationMask.Landscape;
        }
    }
}
