using iPodMobileTerminals002.Models;
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
    public partial class CategoryPage : ContentPage
    {
        
        public CategoryPage()
        {
            InitializeComponent();
            
            BindingContext = new CategoryViewModel();
            Navigation.PopAsync(true);
            
        }

        private void Button_Clicked_Room(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Room(), true);
        }
        private void Button_Clicked_CategoryConfirmation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuItemPage(), true);
            
        }
        void OnTapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new MenuItemPage(), true);
            //DisplayAlert("Save", "Hello", "Close");
            //CheckBox checkBox = new CheckBox { IsChecked = true };
        }  
    }
}