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

        //string colitem;
        //public string col_Item { get { return col_Item; } set { col_Item = value; OnPropertyChanged(colitem); } }

        //var col_item;
        //public var Col_item
        //{
        //    get { return col_item; }
        //    set { col_item = value; OnPropertyChanged("Col_item"); }
        //}

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
                 dogsList1[i].NAME = dogsList1[i].NAME;
                dogsList1[i].WEIGHT = dogsList1[i].WEIGHT;
                dogsList1[i].NEDFORFOOD = dogsList1[i].NEDFORFOOD;
                dogsList1[i].WALKTIME = dogsList1[i].WALKTIME;
                dogsList1[i].FOODTYPE = dogsList1[i].FOODTYPE;
               
            }
           
            BindingContext =this;


        }

        private async void select(object sender, SelectionChangedEventArgs e)
        {
            
            string dogID = (e.CurrentSelection.FirstOrDefault() as Dogs).ID.ToString();
            var authdg=Model.DogsList.Where(a=>a.ID.ToString()== dogID).FirstOrDefault();
            //Col_item = null;
            if(authdg!=null)
            {
                await Navigation.PushAsync(new DogDetailPage(authdg));
            }
            
            // This works because ro te names are unique in this application.
            //await Shell.Current.GoToAsync($"dogdetails?name={dogName}");
            // The full route is shown below.
            //await Shell.Current.GoToAsync($"//Model/DogsList/dogdetails?name={dogName}");
        }

    }

    
    
}