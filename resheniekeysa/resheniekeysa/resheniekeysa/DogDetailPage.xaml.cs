using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogDetailPage : ContentPage
    {

        IList<Dogs> dogsL;
        public IList<Dogs> DogsL
        {
            get { return dogsL; }
            set { dogsL = value; OnPropertyChanged("DogsL"); }
        }
        public DogDetailPage()
        {
            InitializeComponent();
            DogsL = Model.DogsList;
            BindingContext = this;
        }
        public string NAME
        {
            set
            {
                BindingContext = Model.DogsList.FirstOrDefault(m => m.NAME == Uri.UnescapeDataString(value));
            }
        }


        async void Guardianships_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GuardSChoosed());
        }

        async void AllActions_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActionsDogChoosed());
        }
    }
}