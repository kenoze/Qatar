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
    public partial class Registracija : ContentPage
    {
        public Registracija()
        {
            InitializeComponent();
        }
        private async void registracija_Clicked(object sender, EventArgs e)
        {
            var PristupniPodaci =
            $"Username: {username.Text}\n" +
            $"Email: {email.Text}\n" +
            $"Telephone: {telefon.Text}\n" +
            $"Address: {adresa.Text}\n" +
            $"Password: {sifra.Text} \n";
            await DisplayAlert("Registration done", PristupniPodaci,
           "Ok");
            await Navigation.PushAsync(new Page1());
        }
        private void prijava_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}