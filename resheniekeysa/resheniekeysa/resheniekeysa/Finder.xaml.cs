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
	public partial class Finder : ContentPage
	{
		public Finder ()
		{
			InitializeComponent ();
		}

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}