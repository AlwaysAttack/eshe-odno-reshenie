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
       
        
      public IList<Dogs> DogsL { get; set; }
        
        public petAround()
        {
            InitializeComponent();
            DogsL = DBCONN.Db.GetDogs();
            BindingContext= this;
          
           
        }

    }
}