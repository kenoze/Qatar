using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Windows.Input;
namespace Qatar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class live : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public live()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public class HyperlinkSpan : Span
        {
            public static readonly BindableProperty UrlProperty =
                BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan), null);

            public string Url
            {
                get { return (string)GetValue(UrlProperty); }
                set { SetValue(UrlProperty, value); }
            }

            public HyperlinkSpan()
            {
                TextDecorations = TextDecorations.Underline;
                TextColor = Color.Blue;
                GestureRecognizers.Add(new TapGestureRecognizer
                {
                    // Launcher.OpenAsync is provided by Xamarin.Essentials.
                    Command = new Command(async () => await Launcher.OpenAsync(Url))
                });
            }
        }
    }
}

