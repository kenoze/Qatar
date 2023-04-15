using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qatar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pocetna : ContentPage
    {
        public Pocetna()
        {
            InitializeComponent();
        }
        private async void Stadion_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new stadioni());
        private async void predict_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new predict());
        private async void live_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new live());

        private async void grupe_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new groupA());


        private async void karta_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new karta());

        private async void history_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new history());

    }
}