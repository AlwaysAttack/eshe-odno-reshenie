using resheniekeysa.adminpage;
using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detailreq : ContentPage
	{
		public Detailreq (Requests req)
		{
			InitializeComponent ();
		}

        async void acc(object sender, EventArgs e)
        {
            Model.currentreq.STATUS = true;
            DBCONN.Db.UPreq(Model.currentreq);
            await Navigation.PushAsync(new MainPageAdmin());
        }
       
        async void del(object sender, EventArgs e)
        {
            DBCONN.Db.DEL<Requests>(Model.currentreq.ID);
            await Navigation.PushAsync(new MainPageAdmin());
        }
    }
}