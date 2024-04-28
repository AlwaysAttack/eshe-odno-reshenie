using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa.adminpage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class acceptRequests : ContentPage
	{
		IList<Requests> req1;
       
        public IList<Requests> RequestsList1
        {
            get { return req1; }
            set { req1 = value; OnPropertyChanged("DogsList"); }
        }
        public acceptRequests ()
		{
			InitializeComponent();
			req1=Model.RequestsList;
			BindingContext = this;
		}
     public   void review()//обновление для кнопки обновление
        {
            RequestsList1 = Model.RequestsList;
        }
        private async void select(object sender, SelectionChangedEventArgs e)
        {
            
            string reqID = (e.CurrentSelection.FirstOrDefault() as Requests).ID.ToString();
            var authreq = Model.RequestsList.Where(a => a.ID.ToString() == reqID).FirstOrDefault();
            Model.currentreq = authreq;
            //Col_item = null;
            if (authreq != null)
            {
                await Navigation.PushAsync(new Detailreq(Model.currentreq));
            }

          
        }
        
    }
}