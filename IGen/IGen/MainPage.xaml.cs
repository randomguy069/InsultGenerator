using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IGen
{
    public class InsultText
    {
        public string number { get; set; }
        public string language { get; set; }
        public string insult { get; set; }
        public string created { get; set; }
        public string shown { get; set; }
        public string createdby { get; set; }
        public string active { get; set; }
        public string comment { get; set; }

    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void InsultButton_Clicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync("https://evilinsult.com/generate_insult.php?lang=en&type=json"))
                {
                    using (HttpContent content = response.Content)
                    {
                        var mycontent = await content.ReadAsStringAsync();
                        InsultText someText = JsonConvert.DeserializeObject<InsultText>(mycontent);
                       await DisplayAlert("Insult", someText.insult, "Ok");
                    }
                }

            }
            
        }
       

    }
}
