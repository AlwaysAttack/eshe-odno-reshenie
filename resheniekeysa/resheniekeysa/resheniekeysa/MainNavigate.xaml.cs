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
            NavigationPage MainMenu_n = new NavigationPage(new MainMenu());
            MainMenu_n.IconImageSource = "favourites.png";
            Children.Add(MainMenu_n);
           
            Children.Add(new temptest() { IconImageSource="helpPoints.png"});
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