using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace AppMeuQuiz.Droid
{
    [Activity(Label = "Quiz", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            HideStatusBar();
        }

        // Call this method from the constructor after InitializeComponent ();
        public void HideStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var window = activity.Window;
            var attrs = window.Attributes;
            attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
            window.Attributes = attrs;

            window.ClearFlags(WindowManagerFlags.ForceNotFullscreen);
            window.AddFlags(WindowManagerFlags.Fullscreen);

            var decorView = window.DecorView;

            var uiOptions =
                (int)Android.Views.SystemUiFlags.LayoutStable |
                (int)Android.Views.SystemUiFlags.LayoutHideNavigation |
                (int)Android.Views.SystemUiFlags.LayoutFullscreen |
                (int)Android.Views.SystemUiFlags.HideNavigation |
                (int)Android.Views.SystemUiFlags.Fullscreen |
                (int)Android.Views.SystemUiFlags.Immersive;

            decorView.SystemUiVisibility = (Android.Views.StatusBarVisibility)uiOptions;

            window.DecorView.SystemUiVisibility = StatusBarVisibility.Hidden;
        }

        public override void OnBackPressed()
        {

            base.OnBackPressed();
        }
    }
}

