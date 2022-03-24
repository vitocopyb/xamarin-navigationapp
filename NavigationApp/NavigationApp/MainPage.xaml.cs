using NavigationApp.DependencyServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetPlatformMessage();
        }

        private void GetPlatformMessage()
        {
            var service = DependencyService.Get<IPlatformMessage>();
            string message = service.GetMessage();
            lblPlatformMessage.Text = message;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new Page2());
        }
    }
}
