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
        string food_donate;
        string exp;
        string username;
        public string Food_donate
        {
            get { return food_donate; }
            set { food_donate = value; OnPropertyChanged("Food_donate"); }
        }
        public string Exp
        {
            get { return exp; }
            set { exp = value; OnPropertyChanged("Exp"); }
        }
        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }
        }
        public temptest()
        {
            InitializeComponent();
           
                Exp = Model.MainUser.EXP.ToString();
                Food_donate = Model.MainUser.DONATE_FOOD.ToString();
                Username = Model.MainUser.USERNAME.ToString();
            
           
            BindingContext = this;
        }
        protected override bool OnBackButtonPressed()
        {
            // By returning TRUE and not calling base we cancel the hardware back button 🙂
            base.OnBackButtonPressed();
            return true;
        }
       

        private async void Back(object sender, EventArgs e)
        {
            Model.MainUser = null;
            Model.Log_status = false;
            await Navigation.PushAsync(new register());

        }
    }
}