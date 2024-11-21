using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Application name
namespace PoirotCatalogApp 
{
    // The main window of the application
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper; // Declare the database helper class

        // When form starts
        public Form1()
        {
            InitializeComponent(); // Starts the UI elements
            dbHelper = new DatabaseHelper(); // Initialize the database helper
            dataGridView1.AllowUserToAddRows = false; // Prevent addition of rows in DataGridView
            resetButton.Enabled = false; // Disable the Reset Button until a search has been made
            LoadBooks(); // Load all books when the form launches
        }

        // Load all books from table
        private void LoadBooks()
        {
            // Attempt to do these instructions
            try
            {
                dataGridView1.DataSource = dbHelper.GetBooks(); // Retrieve books
                dataGridView1.Columns["CoverImagePath"].Visible = false; // Hide column from user

                // Custom column headings
                dataGridView1.Columns["BookID"].HeaderText = "ID";
                dataGridView1.Columns["Title"].HeaderText = "Title";
                dataGridView1.Columns["ReleaseDate"].HeaderText = "Release Date";
                dataGridView1.Columns["Owned"].HeaderText = "Owned?";
                dataGridView1.Columns["StarRating"].HeaderText = "Rating";
                dataGridView1.Columns["Wishlist"].HeaderText = "Wishlist?";
                dataGridView1.Columns["Notes"].HeaderText = "Summary";

                // Tooltips for clarification
                dataGridView1.Columns["BookID"].ToolTipText = "This is the unique ID for each book.";
                dataGridView1.Columns["Title"].ToolTipText = "The title of the book.";
                dataGridView1.Columns["ReleaseDate"].ToolTipText = "The date the book was published.";
                dataGridView1.Columns["Owned"].ToolTipText = "Do you have this book?.";
                dataGridView1.Columns["Wishlist"].ToolTipText = "Do you need this book?.";
                dataGridView1.Columns["Notes"].ToolTipText = "A brief description of the book's plot.";
            }
            // Error handling
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message); 
            }
        }

        // Search button
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Attempt to do these instructions
            try
            {
                string searchQuery = searchTextBox.Text; // Take user text entered

                // Search query isn't empty
                if (!string.IsNullOrWhiteSpace(searchQuery)) 
                {
                    var result = dbHelper.SearchBooks(searchQuery); // Looks for matches

                    // If books are found, show them
                    if (result != null && result.Rows.Count > 0) 
                    {
                        dataGridView1.DataSource = result;
                    }
                    // If no books are found
                    else
                    {
                        MessageBox.Show("No results found for your search.");
                        dataGridView1.DataSource = null; // Clear the DataGridView if no results
                    }

                    resetButton.Enabled = true; // Enable the Reset Button after search

                }
                // If search box is empty, reload books
                else
                {
                    LoadBooks();
                }
            }
            // If something unexpected occurs, display a message
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
            }
        }

        // Placeholder to be used for user interaction with table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Attempt to do these instructions
            try
            {
                searchTextBox.Text = string.Empty; // Clear search
                LoadBooks(); // Reload books
                resetButton.Enabled = false; // Disable reset button
            }
            // If something unexpected occurs, display a message
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting: " + ex.Message);
            }
        }

        // Home button
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Ask the user if they want to go back to the Start Menu
            var result = MessageBox.Show("Are you sure you want to return to the Home screen?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            // If user chooses yes
            if (result == DialogResult.Yes)
            {
                StartMenu startMenu = new StartMenu(); // Create new instance of start menu
                startMenu.Show(); // Displays the start menu
                this.Close(); // Close catalog page
            }
        }
    }
}
