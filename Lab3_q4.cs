using System;
using MySql.Data.MySqlClient;

namespace Labwork
{
    internal class Lab3_q4
    {
       /* static void Main(string[] args)
        {
            // Connection string to your existing 'employee' database
            string connStr = "server=localhost;user=root;password=;database=employee;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // UPDATE: Change salary of Kusum
                string updateQuery = "UPDATE employee SET salary = 70000 WHERE name = 'Kusum'";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                int rowsUpdated = updateCmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsUpdated} row(s) updated.");

                // DELETE: Remove employee with name 'Rita'
                string deleteQuery = "DELETE FROM employee WHERE name = 'Rita'";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                int rowsDeleted = deleteCmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsDeleted} row(s) deleted.");

                // SELECT: Display updated table
                string selectQuery = "SELECT * FROM employee";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                MySqlDataReader reader = selectCmd.ExecuteReader();

                Console.WriteLine("\nCurrent Employee Records:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]} | Name: {reader["name"]} | Salary: {reader["salary"]}");
                }

                reader.Close();
            }
        }*/
    }
}
