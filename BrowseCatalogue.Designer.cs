// This files controls the layout of the browse page in the application

namespace PoirotCatalogApp
{
    partial class BrowseCatalogue
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelBooks; // Displays books covers and information
        private System.Windows.Forms.Button btnBack; // Button that returns to previous screen

        // Frees resources no longer needed when form is closed
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Form resources no longer in use are cleaned up
            }
            base.Dispose(disposing); // Use form class to clean any other resources no longer needed
        }

        // Code generated in Designer View
        // Do not modify in Code View!
        #region Windows Form Designer generated code

        //
        private void InitializeComponent()
        {

            this.panelBooks = new System.Windows.Forms.Panel(); // Initialise book cover panels
            this.btnBack = new System.Windows.Forms.Button(); // Initialise back button

            // Panel for displaying book covers
            this.panelBooks.Location = new System.Drawing.Point(12, 50);
            this.panelBooks.Size = new System.Drawing.Size(760, 390);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.AutoScroll = true;

            // Back Button
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Add controls to the form
            this.Controls.Add(this.panelBooks);
            this.Controls.Add(this.btnBack);

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BrowseCatalogue";
            this.Text = "Browse Catalogue";
        }

        #endregion
    }
}