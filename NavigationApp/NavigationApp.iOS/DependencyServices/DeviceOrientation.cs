using Foundation;
using NavigationApp.DependencyServices;
using NavigationApp.iOS.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientation))]
namespace NavigationApp.iOS.DependencyServices
{
    public class DeviceOrientation : IDeviceOrientation
    {
        public void LockOrientationLandscape()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.LandscapeLeft), new NSString("orientation"));
        }

        public void LockOrientationPortrait()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
        }

        public void UnlockOrientation()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Unknown), new NSString("orientation"));
        }
    }
}