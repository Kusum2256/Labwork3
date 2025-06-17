using System;
using MySql.Data.MySqlClient;

namespace Labwork
{
    internal class Lab3_q3
    {
        /*static void Main(string[] args)
        {
            // Replace password with your MySQL root password if you have one
            string connStr = "server=localhost;user=root;password=;database=employee;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // INSERT operation
                string insertQuery = "INSERT INTO employee (name, salary) VALUES ('Kusum', 60000)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully.\n");

                // SELECT operation
                string selectQuery = "SELECT * FROM employee";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader reader = selectCmd.ExecuteReader();

                Console.WriteLine("Employee Records:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]} | Name: {reader["name"]} | Salary: {reader["salary"]}");
                }

                reader.Close();
            }
        }*/
    }
}

