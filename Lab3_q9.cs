using System;
using MySql.Data.MySqlClient;

namespace Labwork
{
    internal class Lab3_q9
    {
       /* static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=employee;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    // Example: Select all employees
                    string query = "SELECT id, name, email, salary FROM employee";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Email: {reader["email"]}, Salary: {reader["salary"]}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }*/
    }
}
