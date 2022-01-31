﻿using iPodMobileTerminals002.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iPodMobileTerminals002
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           //MainPage = new OrderConfirmationPage();
           MainPage = new NavigationPage(new StartPage());
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
