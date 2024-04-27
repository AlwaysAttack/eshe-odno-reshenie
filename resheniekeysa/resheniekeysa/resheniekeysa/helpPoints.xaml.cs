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
    public partial class helpPoints : ContentPage
    {
        public helpPoints()
        {
            InitializeComponent();
        }


        async void DonatePointsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new donatePointChoosed());
        }
    }
}