using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class petAround : ContentPage
    {



        IList<Dogs> dogsList1;
          public IList<Dogs> DogsList
        {
            get { return dogsList1; }
            set { dogsList1 = value; OnPropertyChanged("DogsList"); }
        }
        public petAround()
        {
            InitializeComponent();

            dogsList1 = Model.DogsList;
           
            for (int i = 0; i < Model.DogsList.Count; i++)
            {
                 dogsList1[i].NAME = "Имя:" + dogsList1[i].NAME;
                dogsList1[i].WEIGHT = "Масса:" + dogsList1[i].WEIGHT;
                dogsList1[i].NEDFORFOOD = "Норма корма (кг\\день):" + dogsList1[i].NEDFORFOOD;
                dogsList1[i].WALKTIME = "Время прогулки:" + dogsList1[i].WALKTIME;
                dogsList1[i].FOODTYPE = "Тип корма:" + dogsList1[i].FOODTYPE;
               
            }
           
            BindingContext =this;


        }

        private async void select(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new DogDetailPage());
         
        }

    
    }
}