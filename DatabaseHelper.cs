// This file contains database operations

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

// Contains methods to control database operation
public class DatabaseHelper
{
    private string connectionString = "Server=sql8.freemysqlhosting.net;Database=sql8746381;Uid=sql8746381;Pwd=SUVJ3DqUNZ;"; // MySQL database connection

    // Retrieves all tables from the database 
    public DataTable GetBooks()
    {
        // Connect to the MySQL database
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open(); // Open connection of database
            string query = "SELECT * FROM poirotcollection"; // Select all columns from the table
            MySqlCommand command = new MySqlCommand(query, connection); // Prepares SQL command for execution using open connection
            DataTable dataTable = new DataTable(); // Creates a container that stores query results
            MySqlDataAdapter adapter = new MySqlDataAdapter(command); // Runs SQL command
            adapter.Fill(dataTable); // Fills datatable with database data

            return dataTable; // Returns table with data to the program
        }
    }

    // Search for books
    public DataTable SearchBooks(string searchQuery)
    {
        try
        {
            // Creates the connection to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                
                // Search for books using title or tag
                string query = @"
                SELECT DISTINCT b.*
                FROM poirotcollection b
                LEFT JOIN booktags bt ON b.BookID = bt.BookID
                LEFT JOIN tags t ON bt.TagID = t.TagID
                WHERE b.Title LIKE @search OR t.TagName LIKE @search";

                MySqlCommand command = new MySqlCommand(query, connection); // Prepares query
                command.Parameters.AddWithValue("@search", "%" + searchQuery + "%"); // Search term with wildcards for partial matches

                DataTable dataTable = new DataTable(); // Create a new table to store search results
                MySqlDataAdapter adapter = new MySqlDataAdapter(command); // Run query
                adapter.Fill(dataTable); // Stores results in table
                return dataTable; // Return the table with the search results
            }
        }

        // If an error occurs
        catch (Exception ex)
        {
            MessageBox.Show("Error searching books with tags: " + ex.Message);
            return null;
        }
    }

}
