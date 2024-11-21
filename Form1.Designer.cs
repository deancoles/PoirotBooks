// Application name
namespace PoirotCatalogApp
{
    // Main form of application
    partial class Form1
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Do not modify
        #region Windows Form Designer generated code

        // Method for setup of form's visual elements
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Holds form's components
            this.dataGridView1 = new System.Windows.Forms.DataGridView(); // Table that displays book data
            this.searchTextBox = new System.Windows.Forms.TextBox(); // The search box
            this.searchButton = new System.Windows.Forms.Button(); // The search button
            this.resetButton = new System.Windows.Forms.Button(); // The reset button
            this.dataGridViewToolTip = new System.Windows.Forms.ToolTip(this.components); // The tooltips
            this.btnHome = new System.Windows.Forms.Button(); // The home button
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit(); // Create the table
            this.SuspendLayout(); // Prevents layout changes during form setup
        
            // dataGridView1
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right))); // Table stretches to fit form when resized
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells; // Sizes columns to fit their content
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Adjusts column header height automatically
            this.dataGridView1.Location = new System.Drawing.Point(12, 114); // Position
            this.dataGridView1.Name = "dataGridView1"; // Internal name
            this.dataGridView1.Size = new System.Drawing.Size(765, 333); // Table width and height
            this.dataGridView1.TabIndex = 0; // Tab order
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick); // Handles cell clicks

            // searchTextBox
            this.searchTextBox.Location = new System.Drawing.Point(13, 85); // Position
            this.searchTextBox.Name = "searchTextBox"; // Internal name
            this.searchTextBox.Size = new System.Drawing.Size(352, 20); // Search box width and height
            this.searchTextBox.TabIndex = 1; // Tab order
            
            // searchButton
            this.searchButton.Location = new System.Drawing.Point(375, 85); // Position
            this.searchButton.Name = "searchButton"; // Internal name
            this.searchButton.Size = new System.Drawing.Size(75, 20); // Search button width and height
            this.searchButton.TabIndex = 2; // Tab order
            this.searchButton.Text = "Search"; // Button text
            this.searchButton.UseVisualStyleBackColor = true; // Default button styling
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click); // Links button to method

            // resetButton
            this.resetButton.Location = new System.Drawing.Point(455, 85); // Position
            this.resetButton.Name = "resetButton"; // Internal name
            this.resetButton.Size = new System.Drawing.Size(75, 20); // Reset button width and height
            this.resetButton.TabIndex = 3; // Tab order
            this.resetButton.Text = "Reset"; // Button text
            this.resetButton.UseVisualStyleBackColor = true; // Default button styling
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click); // Links button to method

            // btnHome
            this.btnHome.Location = new System.Drawing.Point(13, 13); // Position
            this.btnHome.Name = "btnHome"; // Internal name
            this.btnHome.Size = new System.Drawing.Size(75, 23); // Home button width and hieght
            this.btnHome.TabIndex = 4; // Tab order
            this.btnHome.Text = "Home"; // Button text
            this.btnHome.UseVisualStyleBackColor = true; // Default button styling
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click); // Links button to method

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Form dimensions
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Default scaling for font and controls
            this.ClientSize = new System.Drawing.Size(800, 450); // Form size
            this.Controls.Add(this.btnHome); // Add home button
            this.Controls.Add(this.resetButton); // Add reset button
            this.Controls.Add(this.searchButton); // Add search button
            this.Controls.Add(this.searchTextBox); // Add search box
            this.Controls.Add(this.dataGridView1); // Add table
            this.Name = "Form1"; // Internal name
            this.Text = "Poirot Books"; // Window text
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); // Table initialised
            this.ResumeLayout(false); // Layout behaviour resumed
            this.PerformLayout(); // Completes any layout changes

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1; // Book table
        private System.Windows.Forms.TextBox searchTextBox; // Search box
        private System.Windows.Forms.Button searchButton; // Search button
        private System.Windows.Forms.Button resetButton; // Reset button
        private System.Windows.Forms.ToolTip dataGridViewToolTip; // Tooltip
        private System.Windows.Forms.Button btnHome; // Home button
    }
}

