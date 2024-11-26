using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PoirotCatalogApp.Properties;

namespace PoirotCatalogApp
{
    public partial class BrowseCatalogue : Form
    {
        private string connectionString = "Server=sql8.freemysqlhosting.net;Database=sql8746381;Uid=sql8746381;Pwd=SUVJ3DqUNZ;";

        public BrowseCatalogue()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all book details
                    string query = "SELECT Title, CoverImagePath, Notes FROM poirotcollection";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Clear existing controls in the panel
                    panelBooks.Controls.Clear();

                    int x = 10, y = 10; // Initial position
                    int width = 150, height = 200; // PictureBox size
                    int margin = 10; // Spacing between items

                    while (reader.Read())
                    {
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

                        try
                        {
                            pictureBox.Load(imagePath);
                        }
                        catch
                        {
                            pictureBox.Image = Image.FromFile("Resources/placeholder.png");
                        }

                        panelBooks.Controls.Add(pictureBox);

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
                        x += width + margin;
                        if (x + width > panelBooks.Width)
                        {
                            x = 10;
                            y += height + 70;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }
    }
}
