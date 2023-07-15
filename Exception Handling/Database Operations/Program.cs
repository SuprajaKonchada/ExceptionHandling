using System;
using System.Data.SqlClient;

class DatabaseApp
{
    static void Main()
    {
        string connectionString = @"Data Source=192.168.0.30;Initial Catalog=empID242;Persist Security Info=True;User ID=User5;Password=CDev005#8";
        try
        {
            // Create a SqlConnection object with the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM tb", connection);
                SqlDataReader reader = command.ExecuteReader();

                // Process the query results
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    int age = reader.GetInt32(2);

                    Console.WriteLine($"User: {id}, Name: {name}  Age: {age}");
                }

                // Close the SqlDataReader
                reader.Close();
            }
        }
        catch (SqlException ex)
        { 
            Console.WriteLine("Database error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        Console.ReadLine();
    }
}
