using resheniekeysa.table;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace resheniekeysa
{
    public  class DB
    {
        SQLiteConnection CONNECTION;
        public DB(string path)
        {
            CONNECTION = new SQLiteConnection(path);
            CONNECTION.CreateTable<Dogs>();
            CONNECTION.CreateTable<Users>();
        }

        public List<Users> GetUsers()
        {
            return CONNECTION.Table<Users>().ToList();
        }
        public List<Dogs> GetDogs()
        {
            return CONNECTION.Table<Dogs>().ToList();
        }
        public void SaveUsers(Users user)
        {
        CONNECTION.Insert(user);
        }
        public void SaveDogs(Dogs dog)
        {
            CONNECTION.Insert(dog);
        }
        
    }
}
