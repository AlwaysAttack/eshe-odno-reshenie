using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
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
            //NavigationPage chAccountContent_n = new NavigationPage(new chAccountContent());
            Children.Add(new NavigationPage(new MainMenu()) { BarBackgroundColor = Color.FromHex("65AC64"), IconImageSource="home.png"});
            Children.Add(new NavigationPage(new register()) { IconImageSource = "account.png", BarBackgroundColor = Color.FromHex("65AC64") }) ;
            //Children.Add(new NavigationPage(new temptest()) { IconImageSource = "account.png", BarBackgroundColor = Color.FromHex("65AC64") }) ;
            Children.Add(new NavigationPage(new Finder()) { IconImageSource = "magnifier.png", BarBackgroundColor = Color.FromHex("65AC64") });

            Dogs dog = new Dogs()
            {
                NAME = "даня",
                WEIGHT = "76",
                PATHPHOTO = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Resourses/helpPoints.png"),
                NEDFORFOOD = "0.3",
                BUSY = false,
                GUARDIANSHIP = false,
                WALKTIME = "12.30\\15.30",
                FOODTYPE = Model.foodtype.Pedigree.ToString()
                
            };
            DBCONN.Db.SaveDogs(dog);
            List<Dogs> a = DBCONN.Db.GetDogs();
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].WEIGHT);
            }
        }
    }
}