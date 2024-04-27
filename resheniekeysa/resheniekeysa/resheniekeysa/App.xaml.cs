using resheniekeysa;
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
            routes = new Dictionary<string, Type>();
            //MainPage = new NavigationPage(new MainPage());  
            MainPage = new MainNavigate();
        }
        public static void RegisterRoutes()
        {
            routes.Add("dotdetails", typeof(DogDetailPage));
            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
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
