using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IGen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InsultButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert","Test Alert","Ok");
        }
    }
}
