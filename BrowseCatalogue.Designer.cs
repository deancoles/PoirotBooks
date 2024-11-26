namespace PoirotCatalogApp
{
    partial class BrowseCatalogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Button btnBack;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBooks = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();

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