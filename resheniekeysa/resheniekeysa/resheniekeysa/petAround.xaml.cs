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
        bool busy_;
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
            
           
        }
        public void review()//обновление для кнопки обновление
        {
            DogsList = Model.DogsList;
        }

    }

    
    
}