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
    public partial class groupH : ContentPage
    {
        public groupH()
        {
            InitializeComponent();
        }
        private async void grupa0_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Pocetna());
        }
    }
}