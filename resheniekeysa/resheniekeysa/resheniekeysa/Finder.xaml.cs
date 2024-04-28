using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace resheniekeysa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Finder : ContentPage
	{
        IList<Dogs> _dogslist;
        public IList<Dogs> Dogslist12
        {
            get { return _dogslist; }
            set { _dogslist = value; OnPropertyChanged("Dogslist"); }
        }
		public Finder ()
		{
			InitializeComponent ();
            Dogslist12 = Model.DogsList;
            BindingContext = this;
		}

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string id
            //var authdg = Model.DogsList.Where(a => a.ID.ToString() == /*string id*/).FirstOrDefault();

        }
        private async void select(object sender, SelectionChangedEventArgs e)
        {

            string dogID = (e.CurrentSelection.FirstOrDefault() as Dogs).ID.ToString();
            var authdg = Model.DogsList.Where(a => a.ID.ToString() == dogID).FirstOrDefault();
            //Col_item = null;
            if (authdg != null)
            {
                await Navigation.PushAsync(new DogDetailPage(authdg));
            }


        }
        public void review()//обновление для кнопки обновление
        {
            this.Dogslist12 = Model.DogsList;
        }

    }
}