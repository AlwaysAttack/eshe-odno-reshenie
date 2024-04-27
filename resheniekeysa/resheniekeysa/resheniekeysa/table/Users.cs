using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using SQLite;
namespace resheniekeysa.table
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool ISADMIN { get; set; }
        public int FAVORITES { get; set; }//предпологается хранить id собаки
        public float DONATE_FOOD { get; set; } //пожертвованный корм для собак в кг

        public int EXP { get; set; }
    }
}
