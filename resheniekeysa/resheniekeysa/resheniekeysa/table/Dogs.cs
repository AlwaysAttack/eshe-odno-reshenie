using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace resheniekeysa.table
{
    public class Dogs
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PATHPHOTO { get; set; }
        public string WEIGHT { get; set; }

        public string NEDFORFOOD { get; set; }//потребность в еде кг\день

        public string BUSY { get; set; }//занятость 
        public string GUARDIANSHIP { get; set; }//опекунство
        
        public string WALKTIME { get; set; }//время прогулки

        public string FOODTYPE { get; set; }


    }
}
