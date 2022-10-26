namespace PropertyApp
{
    partial class frmAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgent = new System.Windows.Forms.Button();
            this.pnlAgent = new System.Windows.Forms.Panel();
            this.pnlPropertyAgent = new System.Windows.Forms.Panel();
            this.btnPropertyAgent = new System.Windows.Forms.Button();
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.pnlRental = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRental = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucRental1 = new PropertyApp.ucRental();
            this.ucProperty1 = new PropertyApp.ucProperty();
            this.ucDefault1 = new PropertyApp.ucDefault();
            this.ucAgent1 = new PropertyApp.ucAgent();
            this.ucPropertyAgent1 = new PropertyApp.ucPropertyAgent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 106);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(933, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lblUser);
            this.panel7.Controls.Add(this.lblFullname);
            this.panel7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(971, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 57);
            this.panel7.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.75F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUser.Location = new System.Drawing.Point(19, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Font = new System.Drawing.Font("Mongolian Baiti", 10.75F);
            this.lblFullname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullname.Location = new System.Drawing.Point(7, 33);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(69, 16);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "FullName";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserID.Location = new System.Drawing.Point(941, 18);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(18, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "ID";
            this.lblUserID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "PropertyApp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F);
            this.label2.Location = new System.Drawing.Point(563, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1412, 10);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnAgent);
            this.panel2.Controls.Add(this.pnlAgent);
            this.panel2.Controls.Add(this.pnlPropertyAgent);
            this.panel2.Controls.Add(this.btnPropertyAgent);
            this.panel2.Controls.Add(this.pnlProperty);
            this.panel2.Controls.Add(this.pnlRental);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnProperty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRental);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 510);
            this.panel2.TabIndex = 2;
            // 
            // btnAgent
            // 
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnAgent.ForeColor = System.Drawing.Color.Gold;
            this.btnAgent.Location = new System.Drawing.Point(15, 144);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(187, 48);
            this.btnAgent.TabIndex = 13;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // pnlAgent
            // 
            this.pnlAgent.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAgent.Location = new System.Drawing.Point(3, 144);
            this.pnlAgent.Name = "pnlAgent";
            this.pnlAgent.Size = new System.Drawing.Size(10, 47);
            this.pnlAgent.TabIndex = 12;
            // 
            // pnlPropertyAgent
            // 
            this.pnlPropertyAgent.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlPropertyAgent.Location = new System.Drawing.Point(3, 195);
            this.pnlPropertyAgent.Name = "pnlPropertyAgent";
            this.pnlPropertyAgent.Size = new System.Drawing.Size(10, 47);
            this.pnlPropertyAgent.TabIndex = 10;
            // 
            // btnPropertyAgent
            // 
            this.btnPropertyAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropertyAgent.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnPropertyAgent.ForeColor = System.Drawing.Color.Gold;
            this.btnPropertyAgent.Location = new System.Drawing.Point(14, 195);
            this.btnPropertyAgent.Name = "btnPropertyAgent";
            this.btnPropertyAgent.Size = new System.Drawing.Size(187, 48);
            this.btnPropertyAgent.TabIndex = 11;
            this.btnPropertyAgent.Text = "Property Agent";
            this.btnPropertyAgent.UseVisualStyleBackColor = true;
            this.btnPropertyAgent.Click += new System.EventHandler(this.btnPropertyAgent_Click);
            // 
            // pnlProperty
            // 
            this.pnlProperty.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlProperty.Location = new System.Drawing.Point(3, 95);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(10, 47);
            this.pnlProperty.TabIndex = 10;
            // 
            // pnlRental
            // 
            this.pnlRental.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlRental.Location = new System.Drawing.Point(3, 45);
            this.pnlRental.Name = "pnlRental";
            this.pnlRental.Size = new System.Drawing.Size(10, 47);
            this.pnlRental.TabIndex = 9;
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.Gold;
            this.btnLog.Location = new System.Drawing.Point(14, 246);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(187, 48);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Logout";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnProperty.ForeColor = System.Drawing.Color.Gold;
            this.btnProperty.Location = new System.Drawing.Point(14, 94);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(187, 48);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage:";
            // 
            // btnRental
            // 
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRental.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnRental.ForeColor = System.Drawing.Color.Gold;
            this.btnRental.Location = new System.Drawing.Point(14, 45);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(187, 48);
            this.btnRental.TabIndex = 0;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(208, 604);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 12);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1150, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 498);
            this.panel5.TabIndex = 4;
            // 
            // ucRental1
            // 
            this.ucRental1.Location = new System.Drawing.Point(299, 117);
            this.ucRental1.Name = "ucRental1";
            this.ucRental1.Size = new System.Drawing.Size(768, 453);
            this.ucRental1.TabIndex = 6;
            // 
            // ucProperty1
            // 
            this.ucProperty1.Location = new System.Drawing.Point(300, 117);
            this.ucProperty1.Name = "ucProperty1";
            this.ucProperty1.Size = new System.Drawing.Size(768, 453);
            this.ucProperty1.TabIndex = 5;
            // 
            // ucDefault1
            // 
            this.ucDefault1.Location = new System.Drawing.Point(300, 121);
            this.ucDefault1.Name = "ucDefault1";
            this.ucDefault1.Size = new System.Drawing.Size(786, 468);
            this.ucDefault1.TabIndex = 7;
            // 
            // ucAgent1
            // 
            this.ucAgent1.Location = new System.Drawing.Point(326, 126);
            this.ucAgent1.Name = "ucAgent1";
            this.ucAgent1.Size = new System.Drawing.Size(768, 453);
            this.ucAgent1.TabIndex = 8;
            // 
            // ucPropertyAgent1
            // 
            this.ucPropertyAgent1.Location = new System.Drawing.Point(327, 122);
            this.ucPropertyAgent1.Name = "ucPropertyAgent1";
            this.ucPropertyAgent1.Size = new System.Drawing.Size(768, 453);
            this.ucPropertyAgent1.TabIndex = 9;
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 616);
            this.Controls.Add(this.ucPropertyAgent1);
            this.Controls.Add(this.ucAgent1);
            this.Controls.Add(this.ucDefault1);
            this.Controls.Add(this.ucRental1);
            this.Controls.Add(this.ucProperty1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent";
            this.Load += new System.EventHandler(this.frmAgent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPropertyAgent;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.Panel pnlRental;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private ucProperty ucProperty1;
        private ucRental ucRental1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ucDefault ucDefault1;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Panel pnlAgent;
        private System.Windows.Forms.Button btnPropertyAgent;
        private ucAgent ucAgent1;
        private ucPropertyAgent ucPropertyAgent1;
    }
}