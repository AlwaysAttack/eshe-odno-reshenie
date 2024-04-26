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
        public Image PHOTO { get; set; }
        public float WEIGHT { get; set; }

    }
}
