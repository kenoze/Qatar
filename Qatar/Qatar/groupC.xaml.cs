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
    public partial class groupC : ContentPage
    {
        public groupC()
        {
            InitializeComponent();
        }
        private async void grupaD_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupD());
        }
    }
}