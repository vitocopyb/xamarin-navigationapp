﻿using Android.App;
using Android.Content;
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

[assembly: Dependency(typeof(AndroidMessage))]
namespace NavigationApp.Droid.DependencyServices
{
    public class AndroidMessage : IPlatformMessage
    {
        public string GetMessage()
        {
            return "Hola!, yo estoy en Android";
        }
    }
}