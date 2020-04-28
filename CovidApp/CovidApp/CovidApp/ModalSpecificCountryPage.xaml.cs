using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CovidApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalSpecificCountryPage : ContentPage
    {
        public ModalSpecificCountryPage(CoronavirusDataAllCountries coronavirusDataAllCountries)
        {
            InitializeComponent();

            BindingContext = coronavirusDataAllCountries;
        }
    }
}