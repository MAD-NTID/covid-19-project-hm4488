using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace COVIDProjectApp
{
    public static class SurvivalGuideCollection
    {
        public static ObservableCollection<Guide> Guides { set; get; }

        public static void PopulateData()
        {
            Guides = new ObservableCollection<Guide>
            {
                new Guide(){Info = "Clean your hands!!", Details = "Regularly and thoroughly clean your hands with an alcohol-based hand rub or wash them with soap and water."},
                new Guide() {Info = "Avoid close contact!!", Details = "Avoid close contatc with people who are sick, maintain 3 feet/6 meters away from other people."},
                new Guide() {Info = "Cover your cough!!", Details="Cover your nose and mouth with a disposable tissue or flexed elbow when you cough or sneeze"},
                new Guide(){Info = "Avoid touching eyes, nose and mouth", Details="Hands touch many surfaces and can pick up viruses. Once contaminated, hands can transfer the virus to your eyes, nose or mouth. From there, the virus can enter your body and can make you sick."},
                new Guide(){Info="If you have fever, cough and difficulty breathing, seek medical care early", Details="Stay home if you feel unwell. If you have a fever, cough and difficulty breathing, seek medical attention and call in advance."}



            };
        }

        public class Guide
        {
            public string Info { get; set; }
            //public string ImageUrl { get; set; }
            public string Details { get; set; }


        }
    }
}
