using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using System.Threading.Tasks;
using Android.Util;

namespace AppMeuQuiz.Droid
{
    [Activity(Label = "Quiz 2", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;
            try
            {
                base.OnCreate(bundle);

                global::Xamarin.Forms.Forms.Init(this, bundle);
                LoadApplication(new App());

                AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

                TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;

                AndroidEnvironment.UnhandledExceptionRaiser += AndroidEnvironmentOnUnhandledException;
            }
            catch (Exception ex)
            {
                Log.Debug("Erro Inesperado", ex.Message);
               
            }
           
            //HideStatusBar();
        }

        private void AndroidEnvironmentOnUnhandledException(object sender, RaiseThrowableEventArgs e)
        {
            Log.Debug("AndroidEnvironmentOnUnhandledException >>>", e.Exception.Message);
        }

        private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Log.Debug("TaskSchedulerOnUnobservedTaskException >>>", e.Exception.Message);
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Log.Debug("CurrentDomainOnUnhandledException >>> ", e.ToString());
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

