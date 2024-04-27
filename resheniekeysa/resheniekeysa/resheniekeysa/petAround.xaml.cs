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
        ObservableCollection<Dogs> d=new ObservableCollection<Dogs>() { new Dogs { ID=1,NAME="222"} };
        public IList<Dogs> DogsL1 {
            get { return DogsL; } set { DogsL = value; OnPropertyChanged("Dogs1"); }
        }
        IList<Dogs> DogsL;
        
        public petAround()
        {
            InitializeComponent();
            DogsL1 = DBCONN.Db.GetDogs();
            for (int i = 0; i < Model.DogsList.Count; i++)
            {
                Console.WriteLine(Model.DogsList[i].NAME);
            }
           
        }

        //public void OnAppering()
        //{
          
        //    BindingContext = this;
        //    base.OnAppearing();
        //}
      
    }
}