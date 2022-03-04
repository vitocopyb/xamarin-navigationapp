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