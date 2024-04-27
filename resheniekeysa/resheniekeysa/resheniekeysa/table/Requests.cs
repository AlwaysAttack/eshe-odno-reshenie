using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace resheniekeysa.table
{
    public class Requests
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string TYPE { get; set; }
        public string USERNAM_REQUEST { get; set; }
        public string QUANTITY { get; set; }
        public int ID_DOG { get; set; }
    }
}
