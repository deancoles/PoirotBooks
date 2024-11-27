// This file controls logic and events handling elements for the browse section of the application

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PoirotCatalogApp.Properties;

namespace PoirotCatalogApp
{
    // BrowseCatalogue class inherits from Form class, is able to be used in other classes and forms
    public partial class BrowseCatalogue : Form
    {
        private string connectionString = "Server=sql8.freemysqlhosting.net;Database=sql8746381;Uid=sql8746381;Pwd=SUVJ3DqUNZ;"; // The connection to the MYSQL database

        // Constructs the form
        public BrowseCatalogue()
        {
            InitializeComponent(); // Set up form controls
            LoadBooks(); // Load all of the books into the panel
        }

        // Load and displays books
        private void LoadBooks()
        {
            try
            {
                // Connect to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all book details
                    string query = "SELECT Title, CoverImagePath, Notes FROM poirotcollection";

                    MySqlCommand command = new MySqlCommand(query, connection); // Prepare query
                    MySqlDataReader reader = command.ExecuteReader(); // Run query

                    // Clear existing controls in the panel
                    panelBooks.Controls.Clear();

                    int x = 10, y = 10; // Initial position
                    int width = 150, height = 200; // PictureBox size
                    int margin = 10; // Spacing between items

                    while (reader.Read())
                    {
                        // Get book details
                        string title = reader["Title"].ToString();
                        string imagePath = reader["CoverImagePath"].ToString();
                        string notes = reader["Notes"].ToString();

                        // Create PictureBox for the book cover
                        PictureBox pictureBox = new PictureBox
                        {
                            Location = new Point(x, y),
                            Size = new Size(width, height),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Load cover image
                        try
                        {
                            pictureBox.Load(imagePath);
                        }
                        // If the image isn't able to load
                        catch
                        {
                            pictureBox.Image = Image.FromFile("Resources/placeholder.png");
                        }

                        panelBooks.Controls.Add(pictureBox); // Add the image to the panel

                        // Label for book title
                        Label labelTitle = new Label();
                        labelTitle.Text = title;
                        labelTitle.Location = new Point(x, y + height + 5);
                        labelTitle.Size = new Size(width, 20);
                        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
                        panelBooks.Controls.Add(labelTitle);

                        // Label for book notes
                        Label labelNotes = new Label();
                        labelNotes.Text = notes;
                        labelNotes.Location = new Point(x, y + height + 25);
                        labelNotes.Size = new Size(width, 40);
                        labelNotes.TextAlign = ContentAlignment.TopCenter;
                        labelNotes.AutoEllipsis = true;
                        panelBooks.Controls.Add(labelNotes);

                        // Adjust position for the next item
                        x += width + margin; // Move right for next item
                        if (x + width > panelBooks.Width) // If next item goes beyond panel width
                        {
                            x = 10; // Reset position to the left
                            y += height + 70; // Move down to next row
                        }
                    }
                }
            }
            // Any errors that occur
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        // The back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide form
            StartMenu startMenu = new StartMenu(); // Create new instance of main menu
            startMenu.Show(); // Show main menu
        }
    }
}
