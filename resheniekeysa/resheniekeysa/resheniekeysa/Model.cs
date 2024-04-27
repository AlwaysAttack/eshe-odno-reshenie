using resheniekeysa.table;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace resheniekeysa
{
    public static class Model
    {
        public static IList<Dogs> DogsList { get; set; } 
        public static Users MainUser;
        public static bool Log_status;
        public  enum foodtype
        {
            Purina_Pro_Plan_Opti_Age_Small_Mini_Adult,
            TitBit_Колбаски,
            Brit_Premium_By_Nature,
            Pedigree
        }
         static Model()
        {
          
            DogsList = DBCONN.Db.GetDogs();
        }
        public static void registr_log(string log, string pass)
        {
            Users tempus = DBCONN.Db.GetUser(log);
            if (tempus == null)
            {
                DBCONN.Db.SaveUsers(new table.Users() { USERNAME = log, PASSWORD = pass, });
                MainUser = tempus;
                Log_status = true;
            }
            else
            {

                if (pass == tempus.PASSWORD)
                {

                    MainUser = tempus;
                    Log_status = true;
                    
                }
            }
        }
      
    }
}
