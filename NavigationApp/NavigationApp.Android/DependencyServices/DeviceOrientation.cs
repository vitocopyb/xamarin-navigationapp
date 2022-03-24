using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NavigationApp.DependencyServices;
using NavigationApp.Droid.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientation))]
namespace NavigationApp.Droid.DependencyServices
{
    public class DeviceOrientation : IDeviceOrientation
    {
        [Obsolete]
        public void LockOrientationLandscape()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Landscape;
        }

        [Obsolete]
        public void LockOrientationPortrait()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Portrait;
        }

        [Obsolete]
        void IDeviceOrientation.UnlockOrientation()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Unspecified;
        }
    }
}