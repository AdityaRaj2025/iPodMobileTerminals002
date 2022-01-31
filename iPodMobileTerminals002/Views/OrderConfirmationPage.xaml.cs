using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iPodMobileTerminals002.Views
{
    public partial class OrderConfirmationPage : ContentPage
    {
        public OrderConfirmationPage()
        {
            InitializeComponent();
            Navigation.PopAsync(true);
        }
    }
}
