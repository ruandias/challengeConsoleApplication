using System;
using System.Data.SqlClient;

namespace Covid19
{
    class Program
    {
        static void DatabaseConnection()
        {
            Console.WriteLine("Getting Connection ...");

            var datasource = @"localhost";
            var database = "Covid19";
            var username = "sa"; 
            var password = "1q2w3e4r@#$"; 

            string connString = $"Data Source={datasource};Initial Catalog={database};" +
                                $"Integrated Security=False;User ID={username};Password={password};" +
                                $"Persist Security Info=True;";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Vou me conectar heinnnnnnn carai ...");

                conn.Open();

                Console.WriteLine("Entreiii...Deu bom");
            }
            catch (Exception zica)
            {
                Console.WriteLine("Deu zica: " + zica.Message);
            }
        }

        static void Main(string[] args)
        {
            int option = int.Parse(Console.ReadLine());
            Menu.Show(option);
        }
    }
}
