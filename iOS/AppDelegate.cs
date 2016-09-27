using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using HockeyApp.iOS;

namespace CoffeeTip.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			var manager = BITHockeyManager.SharedHockeyManager;
			manager.Configure("3b8d05111ce247f996fc2edd523c52a3");
			manager.StartManager();
			manager.Authenticator.AuthenticateInstallation();

            //NavigationBar
            UINavigationBar.Appearance.BarTintColor = Color.FromHex("#03A9F4").ToUIColor();
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes{ Font = UIFont.FromName("Avenir-Medium", 17f), TextColor = UIColor.White });

           
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent

            Xamarin.Calabash.Start();
            Xamarin.Forms.Forms.ViewInitialized += (sender, e) =>
                {
                    if (null != e.View.StyleId) 
                    {
                        e.NativeView.AccessibilityIdentifier = e.View.StyleId;
                    }
                };

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

