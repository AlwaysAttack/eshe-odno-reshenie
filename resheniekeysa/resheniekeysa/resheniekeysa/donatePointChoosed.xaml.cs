using resheniekeysa.table;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class donatePointChoosed : ContentPage
	{
		public donatePointChoosed ()
		{
			InitializeComponent ();
		}

       
            async void sendREQUESTdonatePoint_Clicked(object sender, EventArgs e)
            {

                string Namehelper;
                string NumberPhone = PhoneNumber.Text.ToString().Trim();
                if (Model.Log_status == false)
                {
                    Namehelper = NameHelper.Text.ToString().Trim();
                }
                else
                {
                    Namehelper = Model.MainUser.USERNAME;
                }
             
                Requests newrequests = new Requests()
                {
                    ID_DOG = Model.currentDog.ID,
                    USERNAM_REQUEST = Namehelper,
                    PHONE_NUMBER = NumberPhone,
                    QUANTITY = "1",
                    TYPE = Model.Requeststype.Заявка_на_опекунство.ToString(),
                    STATUS=false

                };
                DBCONN.Db.SaveRequests(newrequests);
                await Navigation.PushAsync(new MainMenu());




            }
        
    }
}