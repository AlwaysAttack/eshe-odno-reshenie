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
	public partial class editprofiledetails : ContentPage
	{
		IList<string> array1;
		IList<string> array2;
       
		
		public editprofiledetails ()
		{
			array1 = new List<string> ();
			array2 = new List<string> ();
			array1.Add("Гуляю");

			array1.Add("Кушаю");
			array1.Add("Сплю");
			array2.Add("ДА");
			array2.Add("НЕТ");


            InitializeComponent();
			BindingContext = this;
		}
	}
}