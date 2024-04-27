using resheniekeysa.table;
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
    public partial class MainMenu : ContentPage
    {
      
        public MainMenu()
        {
            InitializeComponent();
            
        }

        //private void favourites(object sender, EventArgs e)
        //{
        //    Console.WriteLine("favourites");
        //}
        async void favourites(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new favourites());

        }

        
        async void helpPoints(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new helpPoints());

        }
        
        async void petAround(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new petAround());

        }
       
  
        async void occupyies(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new occupyies());

        }
      
    }
}