using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainNavigate : TabbedPage
    {
        public MainNavigate ()
        {
            InitializeComponent();
            Children.Add(new MainMenu() { IconImageSource = "favourites.png" });

        }
    }
}