using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Server = copytrade.database.windows.net; Database = transactions; User Id = sa_2; Password = theFlameisburning@heart";
            // [ ] required as your fields contain spaces!!
            string delStmt = "delete from [dbo].[BuildVersion] Where SystemInformationID = @sysinfid";

            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                SqlCommand delCmd = new SqlCommand(delStmt, cnn);
                // use sqlParameters to prevent sql injection!
                
                delCmd.Parameters.AddWithValue("@sysinfid", 7);
                int affectedRows = delCmd.ExecuteNonQuery();
                Console.WriteLine(affectedRows + " rows deleted!");
            }
        }
    }
}


