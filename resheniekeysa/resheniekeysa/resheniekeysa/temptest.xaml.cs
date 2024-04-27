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
    public partial class temptest : ContentPage
    {
        public temptest()
        {
            InitializeComponent();
            
        }
        protected override bool OnBackButtonPressed()
        {
            // By returning TRUE and not calling base we cancel the hardware back button 🙂
            base.OnBackButtonPressed();
            return true;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new register());
        }
    }
}