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
	public partial class MainPageAdmin : ContentPage
	{
		public MainPageAdmin ()
		{
			InitializeComponent ();
        }
        protected override bool OnBackButtonPressed()
        {
            // By returning TRUE and not calling base we cancel the hardware back button 🙂
            base.OnBackButtonPressed();
            return true;
        }
        private void Button_Clicked_acceptHelp(object sender, EventArgs e)
        {

        }
        private void Button_Clicked_editProfiles(object sender, EventArgs e)
        {

        }
        private void Button_Clicked_statusProfiler(object sender, EventArgs e)
        {

        }
        private async void Button_Clicked_acceptRequest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new acceptRequests());
        }

        //  <Button TextColor = "Black" Grid.Row="0" Grid.Column="0" Text="Получить материальную помощь (зачисление волонтёрам)" BackgroundColor="White" CornerRadius="20" Margin="5" Clicked="Button_Clicked_acceptHelp"/>
        //<Button TextColor = "Black" Grid.Row="0" Grid.Column="1" Text="Управление карточками питомцев"  BackgroundColor="White" CornerRadius="20" Margin="5" Clicked="Button_Clicked_editProfiles"/>
        //<Button TextColor = "Black" Grid.Row="1" Grid.Column="1" Text="Присвоить статус опекунства/занятости питомцам" BackgroundColor="White" CornerRadius="20" Margin="5" Clicked="Button_Clicked_statusProfiler"/>
        //<Button TextColor = "Black" Grid.Row="1" Grid.Column="0" Text="Принять запрос пользователя по горячей линии (оператор)" BackgroundColor="White" CornerRadius="20" Margin="5" Clicked="Button_Clicked_acceptRequest"/>
    }
}