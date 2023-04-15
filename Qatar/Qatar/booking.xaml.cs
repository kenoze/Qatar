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
    public partial class booking : ContentPage
    {
        public booking()
        {
            InitializeComponent();
            startDatePicker.MinimumDate = DateTime.Now;
        }

        private void startDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Recalculate();
        }

        private void endDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Recalculate();
        }
        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date;
            resultLabela.Text = String.Format("{0} {1} days before the match!",
                timeSpan.Days, timeSpan.Days == 1 ? "" : "");
        }
    }
}