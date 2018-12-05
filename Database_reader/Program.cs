using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_reader
{
    class Program
    {
        static void Main(string[] args)

        { string con = "Server = copytrade.database.windows.net; Database = transactions; User Id = sa_2; Password = theFlameisburning@heart";
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "Select * from BuildVersion";
                SqlCommand oCmd = new SqlCommand(oString, myConnection); 
                //oCmd.Parameters.AddWithValue("@Fname", fName);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Console.WriteLine(oReader["SystemInformationID"].ToString());
                        Console.WriteLine(oReader["ModifiedDate"].ToString());
                        Console.WriteLine(oReader["Database Version"].ToString());



    }
                    myConnection.Close();
                }
            }
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World of SQL!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
