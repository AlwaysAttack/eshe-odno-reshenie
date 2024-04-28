using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public string Busy
        {
            get {
                if (busy == false)
                {
                    return "Занят";
                }
                else
                {
                    return "Свободен";
                }
                }
            set { Busy = value.ToString();OnPropertyChanged("Busy"); }
          
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
            Model.currentDog = dog;
            //Dogs=dog;
            pathphoto = Model.currentDog.PATHPHOTO;
            name = Model.currentDog.NAME;
            busy = Model.currentDog.BUSY;
            weight = Model.currentDog.WEIGHT;
            nedforfood = Model.currentDog.NEDFORFOOD;
            foodtype = Model.currentDog.FOODTYPE;
            guardianship = Model.currentDog.GUARDIANSHIP;
            walktime = Model.currentDog.WALKTIME;

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

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}