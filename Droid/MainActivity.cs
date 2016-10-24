using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace CoffeeTip.Droid
{
    [Activity(Label = "CoffeeTip.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			string appID = "4cdc7512267845729227f9b6e40bb7af";
			CrashManager.Register(this, appID);
			MetricsManager.Register(Application, appID);
			UpdateManager.Register(this, appID);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Xamarin.Forms.Forms.ViewInitialized += (sender,  e) => 
                {
                    if (!string.IsNullOrWhiteSpace(e.View.StyleId)) 
                    {
                        e.NativeView.ContentDescription = e.View.StyleId;
                    }
                };

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            LoadApplication(new App());
        }
    }
}

