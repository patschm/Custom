using System;
using System.Data.SqlClient;

namespace DataAccessVoorNeanderthalers
{
    class Program
    {
        static string constring = "";

        static void Main(string[] args)
        {
            //TestConnection();
            //ReadData("Guy' Or 1=1;--");
            ReadData("Guy");
        }

        private static void ReadData(string filter)
        {
            string query = "SELECT * FROM [dbo].[Customers] WHERE Name = '" + filter + "'";
            Console.WriteLine(query);
            SqlConnection connction = new SqlConnection(constring);
            connction.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connction;
            command.CommandText = "SELECT * FROM [dbo].[Customers] WHERE Name = @name";
            command.Parameters.AddWithValue("@name", filter);

            SqlDataReader rdr = command.ExecuteReader();

            while(rdr.Read())
            {
                Customer c = new Customer
                {
                    id = (int)rdr[0],
                    Name = rdr[1].ToString(),
                    Gender = rdr[2].ToString()
                };
                Console.WriteLine($"{c.id} {c.Name} {c.Gender} {rdr["Province"]}");
            }
        }

        private static void TestConnection()
        {
            SqlConnection connction = new SqlConnection(constring);
            connction.Open();
            Console.WriteLine(connction.State);
            connction.Close();
        }
    }
}
