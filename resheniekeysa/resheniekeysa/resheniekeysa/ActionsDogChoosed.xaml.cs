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
    public partial class ActionsDogChoosed : ContentPage
    {
        public ActionsDogChoosed()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new walkingTimeChoosed());
        }

        async void DonateFoodButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new donateFoodChoosed());
        }

        async void DonateToy(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new donateToychoosed());
        }
    }
}