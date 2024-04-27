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
	public partial class register : ContentPage
	{
		
		public register ()
		{
			InitializeComponent ();
			
		}

        private async void Reg(object sender, EventArgs e)
        {
			try {
                string log;
                string pass;
                log = Login.Text.Trim();
                pass = Password.Text.Trim();
                Model.registr_log(log, pass);
                Login.Text = null;
                Password.Text = null;
                if (Model.Log_status == true)
                {
                    await Navigation.PushAsync(new temptest());
                }
          
            }
            catch(Exception ex)
            {

            }
			
        }
    }
}