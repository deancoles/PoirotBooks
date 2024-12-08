﻿// This file controls the form control and layout of the main menu

namespace PoirotCatalogApp
{
    // StartMenu class
    partial class StartMenu
    {

        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Frees resources no longer needed when form is closed
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Form resources no longer in use are cleaned up
            }
            base.Dispose(disposing); // Use form class to clean any other resources no longer needed
        }

        // Code generated in design view
        // Do not modify in code view!!!
        #region Windows Form Designer Code


        // Creates the form components
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btnOpenCatalog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBrowseCatalogue = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Database Button
            this.btnOpenCatalog.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCatalog.Location = new System.Drawing.Point(350, 207);
            this.btnOpenCatalog.Name = "btnOpenCatalog";
            this.btnOpenCatalog.Size = new System.Drawing.Size(100, 30);
            this.btnOpenCatalog.TabIndex = 0;
            this.btnOpenCatalog.Text = "Database";
            this.btnOpenCatalog.UseVisualStyleBackColor = true;
            this.btnOpenCatalog.Click += new System.EventHandler(this.btnOpenCatalog_Click);

            // Exit Button
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(350, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Message on main menu
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(185, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hercule Poirot Book Catalogue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // About button
            this.btnAbout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(350, 257);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 30);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);

            // Settings button
            this.btnSettings.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(350, 307);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // Browse button
            this.btnBrowseCatalogue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCatalogue.Location = new System.Drawing.Point(350, 156);
            this.btnBrowseCatalogue.Name = "btnBrowseCatalogue";
            this.btnBrowseCatalogue.Size = new System.Drawing.Size(100, 30);
            this.btnBrowseCatalogue.TabIndex = 0;
            this.btnBrowseCatalogue.Text = " Browse ";
            this.btnBrowseCatalogue.UseVisualStyleBackColor = true;
            this.btnBrowseCatalogue.Click += new System.EventHandler(this.btnBrowseCatalogue_Click);

            // Main menu
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseCatalogue);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poirot Book Catalogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declares all buttons and labels used within form
        private System.Windows.Forms.Button btnBrowseCatalogue;
        private System.Windows.Forms.Button btnOpenCatalog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
    }
}