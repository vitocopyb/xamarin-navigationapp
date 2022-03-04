using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage = new NavigationPage(new MainPage());
            MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
