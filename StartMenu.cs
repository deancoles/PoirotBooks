// This file controls logic and events handling elements of the main menu of the application

using System; // Basics classes and types
using System.Drawing; // Graphics
using System.Media; // Allows sound
using System.Windows.Forms; // Gives tools used within Windows Forms

namespace PoirotCatalogApp
{
    // StartMenu class inherits from Form class, is able to be used in other classes and forms
    public partial class StartMenu : Form
    {
        private SoundPlayer soundPlayer; // Controls the background music of application

        // The Main Menu
        public StartMenu()
        {
            InitializeComponent(); // Begin creating components of form
            LoadMusic();
            PlayMusic();
            label1.BackColor = Color.Transparent; // Sets label on Main Menu to be transparent
        }

        // Loads music
        private void LoadMusic()
        {
            soundPlayer = new SoundPlayer("Resources/Poirot.wav");
        }

        // Plays music
        private void PlayMusic()
        {
            try
            {
                soundPlayer.PlayLooping(); // Loops music
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing music: " + ex.Message); // If music cannot play
            }
        }

        // Stops music
        private void StopMusic()
        {
            try
            {
                soundPlayer.Stop(); // Stop the music
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping music: " + ex.Message);
            }
        }

        // When form is closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopMusic(); // Stop music when closing the form
        }

        // The browse button on the main menu
        private void btnBrowseCatalogue_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the start menu
            BrowseCatalogue browseCatalogueForm = new BrowseCatalogue(); // Create new form
            browseCatalogueForm.Show(); // Show new form
        }

        // The Database button on the main menu
        private void btnOpenCatalog_Click(object sender, EventArgs e)
        {
            StopMusic(); // Stop music before going to new form
            Form1 catalogForm = new Form1(); // Create the database form
            catalogForm.Show(); // Show new database form
            this.Hide(); // Hide main menu
        }

        // About button on main menu
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poirot Book Catalog Application\nVersion 1.1\nDeveloped by Dean Coles", "About");
        }

        // Settings button on main menu
        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder\nFuture settings will be added in later versions", "Settings");
        }

        // Exit button on main menu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes application
        }
        
        // Placeholder for display message interactivity
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
