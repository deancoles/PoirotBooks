using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PoirotCatalogApp
{
    public partial class StartMenu : Form
    {
        private SoundPlayer soundPlayer;

        public StartMenu()
        {
            InitializeComponent();
            LoadMusic();
            PlayMusic();
            label1.BackColor = Color.Transparent;
        }

        private void LoadMusic()
        {
            // Load the music file
            soundPlayer = new SoundPlayer("Resources/Poirot.wav");
        }

        private void PlayMusic()
        {
            try
            {
                soundPlayer.PlayLooping(); // Play music in a loop
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing music: " + ex.Message);
            }
        }

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopMusic(); // Stop music when closing the form
        }

        private void btnOpenCatalog_Click(object sender, EventArgs e)
        {
            StopMusic(); // Stop music before navigating
            Form1 catalogForm = new Form1();
            catalogForm.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poirot Book Catalog Application\nVersion 1.1\nDeveloped by Dean Coles", "About");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder\nFuture settings will be added in later versions", "Settings");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
