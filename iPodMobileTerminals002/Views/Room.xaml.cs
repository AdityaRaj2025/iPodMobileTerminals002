using iPodMobileTerminals002.ViewModels;
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
    public partial class Room : ContentPage
    {
        public Room()
        {
            InitializeComponent();
            BindingContext = new RoomViewModel();
            Navigation.PopAsync(true);
        }
        private void Button_Clicked_Top(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartPage(), true);
        }
        private void Button_Clicked_Next(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategoryPage(), true);
        }
        
    }
}