﻿using System;
using System.Security.Cryptography.X509Certificates;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CovidApp
{
    public partial class App : Application
    {

        public static bool flag = true;
        public App()
        {
            InitializeComponent();
           
            MainPage = new MainPage();
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
