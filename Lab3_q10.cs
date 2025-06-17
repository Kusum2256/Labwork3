using System;
using MySql.Data.MySqlClient;

namespace Labwork
{
    internal class Lab3_q10
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;password=;database=tourism_db";

            Console.Write("Enter Tour Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Duration (in days): ");
            int duration = Convert.ToInt32(Console.ReadLine());

            DateTime createdDate = DateTime.Now;

            string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) " +
                           "VALUES (@title, @description, @duration, @createdDate)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@createdDate", createdDate);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                        Console.WriteLine("Tour Destination info saved successfully!");
                    else
                        Console.WriteLine("Failed to insert data.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
