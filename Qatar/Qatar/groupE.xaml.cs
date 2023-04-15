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
    public partial class groupE : ContentPage
    {
        public groupE()
        {
            InitializeComponent();
        }
        private async void grupaF_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupF());
        }
    }
}