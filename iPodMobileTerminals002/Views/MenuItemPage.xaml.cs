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
    public partial class MenuItemPage : ContentPage
    {
        
        public MenuItemPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
            BindingContext = new MenuItemViewModel();            
        }

        private void Button_Clicked_Category(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategoryPage(), true);
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = e.PreviousSelection;
            var current = e.CurrentSelection;                      
        }

    }
}