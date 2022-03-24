using Foundation;
using NavigationApp.DependencyServices;
using NavigationApp.iOS.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSMessage))]
namespace NavigationApp.iOS.DependencyServices
{
    public class iOSMessage : IPlatformMessage
    {
        public string GetMessage()
        {
            return "Hola!, yo estoy en iOS";
        }
    }
}