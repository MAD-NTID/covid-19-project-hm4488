
using Newtonsoft.Json;
using RestSharp;
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
    public partial class InformationDataPage : ContentPage
    {

        public static List<CoronavirusDataAllCountries> coronavirusDataAllCountries = new List<CoronavirusDataAllCountries>();

        public  InformationDataPage()
        {
            InitializeComponent();
            ApistuffAsync();


            //carouselCollectionView.ItemsSource = coronavirusDataAllCountries;
            collectionView.ItemsSource = coronavirusDataAllCountries;

            
            
        }

        
        public void ApistuffAsync()
        {
           var client = new RestClient("https://covid-19-data.p.rapidapi.com/country/all?format=undefined");

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-host", "covid-19-data.p.rapidapi.com");

            request.AddHeader("x-rapidapi-key", "54c7eaa2camsh3bfb99864b4ad3ep111186jsn385646837c47");

            IRestResponse response =  client.Execute(request);

            var cData = JsonConvert.DeserializeObject<System.Collections.Generic.List<CoronavirusDataAllCountries>>(response.Content);

            for (int i = 0; i < cData.Count; i++)
            {
                CoronavirusDataAllCountries coronavirusData = new CoronavirusDataAllCountries(cData[i].country, cData[i].confirmed, cData[i].recovered, cData[i].critical, cData[i].deaths, cData[i].latitude, cData[i].longitude);

                coronavirusDataAllCountries.Add(coronavirusData);
            }

            
            
           
             
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            collectionView.ItemsSource = GetSearchResults(searchBar.Text);
        }

        public static List<CoronavirusDataAllCountries> GetSearchResults(string queryString)
        {
            var normalizedQuery = queryString?.ToLower() ?? "";
            return coronavirusDataAllCountries.Where(f => f.country.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }

       
    }

    public class CoronavirusDataAllCountries
    {
        public string country { get; set; }
        public int confirmed { get; set; }
        public int recovered { get; set; }
        public int critical { get; set; }
        public int deaths { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }

        public CoronavirusDataAllCountries(string _country, int _confirmed, int _recovered, int _critical, int _deaths, double? _latitude, double? _longitude)
        {
            country = _country;
           
            confirmed = _confirmed;
            
            recovered = _recovered;
            
            critical = _critical;
            
            deaths = _deaths;
            
            latitude = _latitude;
            
            longitude = _longitude;
        }
    }
}