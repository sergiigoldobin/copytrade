using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Insert
{
    class Program
    {
        private static object textbox2;

        static void Main(string[] args)
        {
            string con = "Server = copytrade.database.windows.net; Database = transactions; User Id = sa_2; Password = theFlameisburning@heart";
            // [ ] required as your fields contain spaces!!
            string insStmt = "insert into [dbo].[BuildVersion] ([Database Version], [VersionDate], [ModifiedDate]) values (@databaseversion,@versiondate,@modifieddate)";

            using (SqlConnection cnn = new SqlConnection(con))
            { 
                cnn.Open();
                SqlCommand insCmd = new SqlCommand(insStmt, cnn);
                // use sqlParameters to prevent sql injection!
                DateTime date = new DateTime (2018, 12, 01, 23, 59, 59);
                String databasever = "10.50.100000.5";
                            
                insCmd.Parameters.AddWithValue("@databaseversion", databasever);
                insCmd.Parameters.AddWithValue("@versiondate", date);
                insCmd.Parameters.AddWithValue("@modifieddate", new DateTime(2018, 12, 02, 15, 34, 05));
                int affectedRows = insCmd.ExecuteNonQuery();
                Console.WriteLine(affectedRows + " rows inserted!");
            }
        }
    }
}
