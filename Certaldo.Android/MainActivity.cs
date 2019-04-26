using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Parallelo.Maps.Android;
using Android.Webkit;
using Plugin.Permissions;
using Plugin.CurrentActivity;

using FFImageLoading.Forms.Droid;
using Xamarin.Forms;


namespace Certaldo.Droid
{
    [Activity(Label = "Certaldo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
            base.OnCreate(savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            MapRenderer.Init(savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            //CachedImageRenderer.Init(enableFastRenderer: false);
            //FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: false);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CarouselView.FormsPlugin.Android.CarouselViewRenderer.Init();
            Parallelo.Android.Setup.Init(this, savedInstanceState);


           
#if DEBUG
            Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
#endif

            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}