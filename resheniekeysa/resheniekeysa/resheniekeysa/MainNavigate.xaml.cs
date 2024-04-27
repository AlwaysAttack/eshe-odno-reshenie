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
    public partial class MainNavigate : TabbedPage
    {
        public MainNavigate ()
        {
            InitializeComponent();
            NavigationPage chAccountContent_n = new NavigationPage(new chAccountContent());

            NavigationPage MainMenu_n = new NavigationPage(new MainMenu())
            {
                BarBackgroundColor = Color.FromHex("65AC64")
                
            };
            
            MainMenu_n.IconImageSource = "home.png";
            //NavigationPage.SetTitleIconImageSource(this, "logoDR.png");
            Children.Add(MainMenu_n);

            Children.Add(new NavigationPage(new temptest()) { IconImageSource = "account.png", BarBackgroundColor = Color.FromHex("65AC64") }) ;
            Children.Add(new NavigationPage(new Finder()) { IconImageSource = "magnifier.png", BarBackgroundColor = Color.FromHex("65AC64") });
            //DB db = new DB("DataBase.db");
            //Dogs dog = new Dogs()
            //{
            //    NAME = "1",
            //    WEIGHT = 1,
            //    PHOTO = null

            //};
            //db.SaveDogs(dog);
            //List<Dogs> a=db.GetDogs();
            //for (int i = 0; i < a.Count; i++)
            //{
            //    Console.WriteLine(a[i].WEIGHT);
            //}
        }
    }
}