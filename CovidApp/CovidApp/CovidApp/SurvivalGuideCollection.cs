using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CovidApp
{
    public static class SurvivalGuideCollection
    {
        public static ObservableCollection<Guide> Guides { set; get; }

        public static void PopulateData()
        {
            Guides = new ObservableCollection<Guide>
            {
                new Guide(){Info = "Clean your hands!!", JsonFilePath="wash_your_hands.json", Details = "Regularly and thoroughly clean your hands with an alcohol-based hand rub or wash them with soap and water."},
                new Guide() {Info = "Avoid close contact!!", JsonFilePath="avoid_close_contact.json", Details = "Avoid close contatc with people who are sick, maintain 3 feet/6 meters away from other people."},
                new Guide() {Info = "Cover your cough!!", JsonFilePath="cover_your_cough.json", Details="Cover your nose and mouth with a disposable tissue or flexed elbow when you cough or sneeze."},
                new Guide(){Info = "Avoid touching eyes, nose and mouth!!", JsonFilePath="avoid_touching_your_face.json", Details="Hands touch many surfaces and can pick up viruses. Once contaminated, hands can transfer the virus to your eyes, nose or mouth."},
                new Guide(){Info="If you have fever, cough and difficulty breathing, seek medical care early!!", JsonFilePath="seek_medical_care.json", Details="Stay home if you feel unwell. If you have a fever, cough and difficulty breathing, seek medical attention and call in advance."},
                new Guide(){Info="Try to stay home!!", JsonFilePath="stay_stay_home.json", Details="Staying at home reduces the spread of coronavirus and reduces the risk of getting infected as well as spread to other people."}


            };
        }

        public class Guide
        {
            public string Info { get; set; }
           public string JsonFilePath { get; set; }
            public string Details { get; set; }


        }
    }
}
