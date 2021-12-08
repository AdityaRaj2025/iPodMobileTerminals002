using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPodMobileTerminals002.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
        }

        private void Order_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Room(), true);
        }
    }
}