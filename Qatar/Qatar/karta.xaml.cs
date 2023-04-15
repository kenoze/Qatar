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
    public partial class karta : ContentPage
    {
        public karta()
        {
            InitializeComponent();
        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {
                kategorijaNameLabel.Text =

                (string)picker.ItemsSource[selectedIndex];
            }
        }
        async private void posaljipodatke_Clicked(object sender,
        EventArgs e)
        {
            var Proizvod =
            $"Sector: {opis.Text}\n \n" +
            $"Location: {lokacija.Text}\n" +
            $"Telephone: {kontaktbroj.Text}\n \n" +
            $"eMail: {email.Text} \n";
            await DisplayAlert(kategorijaNameLabel.Text, Proizvod, "Order accepted!");
        }

        private async void karta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new booking());
        }
    }
}
