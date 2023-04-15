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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        async private void prijava_Clicked(object sender, EventArgs e)
        {
            var PristupniPodaci =
            $"Username: {username.Text}\n" +
            $"Password: {sifra.Text}\n";
            await DisplayAlert("Welcome", PristupniPodaci, "Ok");
            await Navigation.PushAsync(new Pocetna());
        }
    }
}