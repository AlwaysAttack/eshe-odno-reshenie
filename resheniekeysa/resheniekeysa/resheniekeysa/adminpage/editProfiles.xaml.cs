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
	public partial class editProfiles : ContentPage
	{
		IList<Dogs> _dogs;
		public IList<Dogs> DogsL
		{
			get { return _dogs; }
			set { _dogs = value; OnPropertyChanged("DogsL"); } }
		public editProfiles ()
		{
            InitializeComponent();
            DogsL = Model.DogsList;
			BindingContext = this;
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