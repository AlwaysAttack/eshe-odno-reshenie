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
    public partial class donateFoodChoosed : ContentPage
    {
        public donateFoodChoosed()
        {
            InitializeComponent();
        }

        async void sendREQUESTdonateFood_Clicked(object sender, EventArgs e)
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
                string quent = Quent.Text.ToString().Trim();
                Requests newrequests = new Requests()
                {
                    ID_DOG = Model.currentDog.ID,
                    USERNAM_REQUEST = Namehelper,
                    PHONE_NUMBER = NumberPhone,
                    QUANTITY = quent,
                    TYPE = Model.Requeststype.Корм.ToString(),

                    STATUS=false
                };
                DBCONN.Db.SaveRequests(newrequests);
                await Navigation.PushAsync(new MainMenu());
            
         
         

        }
    }
}