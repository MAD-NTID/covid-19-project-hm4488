using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COVIDProjectApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SurvivalGuideCollection.PopulateData();

            MainPage = new SurvivalGuidePage();
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
