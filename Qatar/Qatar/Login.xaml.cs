using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Qatar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void prijava_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private void registracija_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registracija());
        }
    }
}
   