﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qatar
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())

            {
                BarBackgroundColor = Color.FromHex("#800922"),
                BarTextColor = Color.White,
            };


            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#800922"),
                BarTextColor = Color.White,
            };
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