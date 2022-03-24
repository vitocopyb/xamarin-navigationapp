using NavigationApp.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //your code here;
            //DependencyService.Get<IDeviceOrientation>().LockOrientationPortrait();
            DependencyService.Get<IDeviceOrientation>().LockOrientationLandscape();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DependencyService.Get<IDeviceOrientation>().UnlockOrientation();
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new Page3());
        }

        private void BtnPrev_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PopAsync();
        }

        private void btnModal_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushModalAsync(new ModalPage());
        }
    }
}