using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace resheniekeysa
{
    public static  class DBCONN
    {
       static  DB db;
        public static DB Db
        {
            get
            {
                if (db == null)
                {
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DataBase.sqlite3"));
                }
                return db;
            }
        }
    }
}
