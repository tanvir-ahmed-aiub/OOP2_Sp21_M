using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Server=DESKTOP-1HKAK02; Database=demo_m_sp21; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            /*conn.Open();
            string query = "insert into users values ('arnab','22237','user')";
            SqlCommand cmd = new SqlCommand(query,conn);
            int row_effected = cmd.ExecuteNonQuery();
            if (row_effected > 0)
            {
                Console.WriteLine("Successfully Added");
            }
            else {
                Console.WriteLine("Not Added");
            }
            conn.Close();*/
            conn.Open();
            string query = "select * from users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\t\tName\t\tType");
            while (reader.Read()) {
               
                int id =(int) reader.GetInt64(reader.GetOrdinal("id"));
                string uname = reader.GetString(1);
                string type = reader.GetString(reader.GetOrdinal("type"));
                Console.WriteLine("{0}\t{1}\t{2}",id, uname, type);
            }
            conn.Close();
        }
    }
}
