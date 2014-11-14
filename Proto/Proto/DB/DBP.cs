using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proto.DB
{
    class DBP
    {
        string connectionString = "Data Source=MODB.sdb";

        public DBP()
        {
            using(System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                using(System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();



                }
            }
        }

    }
}
