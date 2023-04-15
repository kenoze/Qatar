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
    public partial class groupG : ContentPage
    {
        public groupG()
        {
            InitializeComponent();
        }
        private async void grupaH_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new groupH());
        }
    }
}