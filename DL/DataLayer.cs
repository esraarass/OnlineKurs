using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineKurs.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database="21015221025_db",
                UserID="root",
                Password="Blqn34863606",
            } .ConnectionString
            );
        public static int UyeEkle(Uye m) 
        {
            try
            {
                if(conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("komut,conn");
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("", "");

            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                conn.Close();
            }

            return -1;
        }
         

        
    }
}
