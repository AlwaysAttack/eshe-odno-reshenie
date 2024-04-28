using resheniekeysa;
using resheniekeysa.adminpage;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
    public partial class App : Application
    {
        static Dictionary<string, Type> routes;
        public App()
        {
            InitializeComponent();

            MainPage = new MainNavigate();  
            ////MainPage  = new editprofiledetails();
            //MainPage = new NavigationPage(new MainNavigate());

        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
