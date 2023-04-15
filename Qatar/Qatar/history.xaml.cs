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
    public partial class history : ContentPage
    {
        public history()
        {
            InitializeComponent();
            var list = new List<string>
            {
                "Russia 2018." +
                " Winner : France. Runner Up : Croatia.",
                "Brazil 2014." +
                "Winner : Germany. Runner Up : Argentina.",
                "South Africa 2010."  +
                "Winner : Spain.Runner Up:Netherland" ,
                "Germany 2006." +
                "Winner : Italy.Runner Up:France" ,
                "Japan 2002. " +
                "Winner : Brazil.Runner Up:Germany",
                "France 1988." +
                "Winner:France.Runner Up:Brazil" ,
                "Uruguay 1930." +
                "Winner:Uruguay.Runner Up:Argentina"
            };
            TheCarousel.ItemsSource = list;
        }
    }
}



