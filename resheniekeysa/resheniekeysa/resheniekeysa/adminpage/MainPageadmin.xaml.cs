using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Klop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           
            InitializeComponent();
        }

        //Clicked="Button_Clicked_acceptHelp"/>
        //<Button Grid.Row="0" Grid.Column= "1" Text= "Управление карточками питомцев"  BackgroundColor= "White" CornerRadius= "20" Margin= "5" Clicked= "Button_Clicked_editProfiles" />
        //< Button Grid.Row= "1" Grid.Column= "1" Text= "Присвоить статус опекунства/занятости питомцам" BackgroundColor= "White" CornerRadius= "20" Margin= "5" Clicked= "Button_Clicked_statusProfiler" />
        //< Button Grid.Row= "1" Grid.Column= "0" Text= "Принять запрос пользователя по горячей линии (оператор)" BackgroundColor= "White" CornerRadius= "20" Margin= "5" Clicked= "Button_Clicked_acceptRequest" />

        async void Button_Clicked_acceptHelp(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new acceptHelp());
        } 
        async void Button_Clicked_editProfiles(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new editProfiles());
        } 
        async void Button_Clicked_statusProfiler(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new statusProfiler());
        } 
        async void Button_Clicked_acceptRequest(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new acceptRequest());
        }
    }
}
