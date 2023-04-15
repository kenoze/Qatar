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
    public partial class predict : ContentPage
    {
        int randomValue;
        List<string> zastavaList;
        public predict()
        {
            InitializeComponent();
            zastavaList = new List<string>();
            zastavaList.Add("argi.png");
            zastavaList.Add("ger.png");
            zastavaList.Add("cro.png");
            zastavaList.Add("sen.png");
            zastavaList.Add("mar.png");
            zastavaList.Add("braa.png");



        }
        private void btn_Clicked(object sender, EventArgs e)
        {
            randomValue = new Random().Next(6);
            image.Source = ImageSource.FromResource("Qatar.images." + zastavaList[randomValue]);
        }
    }
}