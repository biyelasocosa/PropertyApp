namespace PropertyApp
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.btnAgencies = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRental = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.ucUserReport1 = new PropertyApp.ucUserReport();
            this.ucPropertyReport1 = new PropertyApp.ucPropertyReport();
            this.ucLocationReport1 = new PropertyApp.ucLocationReport();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgencies
            // 
            this.btnAgencies.Location = new System.Drawing.Point(661, 76);
            this.btnAgencies.Name = "btnAgencies";
            this.btnAgencies.Size = new System.Drawing.Size(117, 34);
            this.btnAgencies.TabIndex = 7;
            this.btnAgencies.Text = "Agency";
            this.btnAgencies.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 10);
            this.panel2.TabIndex = 1;
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(538, 76);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(117, 34);
            this.btnRental.TabIndex = 6;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(168, 76);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(117, 34);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(293, 76);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(117, 34);
            this.btnProperty.TabIndex = 4;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(417, 76);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(117, 34);
            this.btnLocation.TabIndex = 5;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // ucUserReport1
            // 
            this.ucUserReport1.Location = new System.Drawing.Point(37, 119);
            this.ucUserReport1.Name = "ucUserReport1";
            this.ucUserReport1.Size = new System.Drawing.Size(882, 462);
            this.ucUserReport1.TabIndex = 8;
            // 
            // ucPropertyReport1
            // 
            this.ucPropertyReport1.Location = new System.Drawing.Point(36, 120);
            this.ucPropertyReport1.Name = "ucPropertyReport1";
            this.ucPropertyReport1.Size = new System.Drawing.Size(882, 462);
            this.ucPropertyReport1.TabIndex = 9;
            // 
            // ucLocationReport1
            // 
            this.ucLocationReport1.Location = new System.Drawing.Point(33, 121);
            this.ucLocationReport1.Name = "ucLocationReport1";
            this.ucLocationReport1.Size = new System.Drawing.Size(882, 462);
            this.ucLocationReport1.TabIndex = 10;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 606);
            this.Controls.Add(this.ucLocationReport1);
            this.Controls.Add(this.ucPropertyReport1);
            this.Controls.Add(this.ucUserReport1);
            this.Controls.Add(this.btnAgencies);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgencies;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnLocation;
        private ucUserReport ucUserReport1;
        private ucPropertyReport ucPropertyReport1;
        private ucLocationReport ucLocationReport1;
    }
}