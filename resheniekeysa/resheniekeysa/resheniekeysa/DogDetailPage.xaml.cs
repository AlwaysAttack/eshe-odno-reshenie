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
    [QueryProperty("Name", "name")]
    public partial class DogDetailPage : ContentPage
    {

        Dogs Dogs;
        string pathphoto;
        string name;
        bool busy;
        bool guardianship;
        string walktime;
        string foodtype;
        string nedforfood;
        string weight;
       
        public string PathPhoto
        {
            get { return pathphoto; }
            set { pathphoto = value; OnPropertyChanged("PathPhoto"); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        public bool Busy
        {
            get { return busy; }
            set { busy = value; OnPropertyChanged("Busy"); }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; OnPropertyChanged("Weight"); }
        }

        public string Nedforfood
        {
            get { return nedforfood; }
            set { nedforfood = value; OnPropertyChanged("Nedforfoof"); }
        }
        public string Foodtype
        {
            get { return foodtype; }
            set { foodtype = value; OnPropertyChanged("Foodtype"); }
        }
        public bool Guardianship
        {
            get { return guardianship; }
            set { guardianship = value; OnPropertyChanged("Guardianship"); }
        }
        public string Walktime
        {
            get { return walktime; }
            set { walktime = value; OnPropertyChanged("Walktime"); }
        }
        public DogDetailPage( Dogs dog)
        {
            InitializeComponent();

            //Dogs=dog;
            PathPhoto = dog.PATHPHOTO;
            Name= dog.NAME;
            Busy = dog.BUSY;
            Weight = dog.WEIGHT;
            Nedforfood = dog.NEDFORFOOD;
            Guardianship = dog.GUARDIANSHIP;
            Walktime = dog.WALKTIME;
            Foodtype = dog.FOODTYPE;
            BindingContext = this;
        }


        //public string Name
        //{
        //    set
        //    {
        //        BindingContext = Model.DogsList.FirstOrDefault(m => m.NAME == Uri.UnescapeDataString(value));
        //    }
        //}
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