namespace PropertyApp
{
    partial class frmTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTenant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.btnProperty = new System.Windows.Forms.Button();
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.pnlPropertyType = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucDefault1 = new PropertyApp.ucDefault();
            this.ucPropertyList1 = new PropertyApp.ucPropertyList();
            this.ucApply1 = new PropertyApp.ucApply();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblUserID);
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
            this.pictureBox2.Location = new System.Drawing.Point(955, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblUser);
            this.panel7.Controls.Add(this.lblFullname);
            this.panel7.Font = new System.Drawing.Font("Mongolian Baiti", 10.25F);
            this.panel7.Location = new System.Drawing.Point(993, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(142, 50);
            this.panel7.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUser.Location = new System.Drawing.Point(20, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFullname.Location = new System.Drawing.Point(10, 31);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(63, 15);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "FullName";
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
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserID.Location = new System.Drawing.Point(964, 18);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(18, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "ID";
            this.lblUserID.Visible = false;
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
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.pnlLogout);
            this.panel2.Controls.Add(this.btnProperty);
            this.panel2.Controls.Add(this.pnlProperty);
            this.panel2.Controls.Add(this.pnlPropertyType);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnApply);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 510);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(3, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 47);
            this.panel6.TabIndex = 12;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLogout.Location = new System.Drawing.Point(3, 195);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(10, 47);
            this.pnlLogout.TabIndex = 10;
            // 
            // btnProperty
            // 
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnProperty.ForeColor = System.Drawing.Color.Gold;
            this.btnProperty.Location = new System.Drawing.Point(14, 94);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(187, 48);
            this.btnProperty.TabIndex = 11;
            this.btnProperty.Text = "Properties";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // pnlProperty
            // 
            this.pnlProperty.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlProperty.Location = new System.Drawing.Point(3, 144);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(10, 47);
            this.pnlProperty.TabIndex = 10;
            // 
            // pnlPropertyType
            // 
            this.pnlPropertyType.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlPropertyType.Location = new System.Drawing.Point(3, 45);
            this.pnlPropertyType.Name = "pnlPropertyType";
            this.pnlPropertyType.Size = new System.Drawing.Size(10, 47);
            this.pnlPropertyType.TabIndex = 9;
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.Gold;
            this.btnLog.Location = new System.Drawing.Point(14, 195);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(187, 48);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Logout";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.Gold;
            this.btnProfile.Location = new System.Drawing.Point(14, 143);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(187, 48);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "My Details";
            this.btnProfile.UseVisualStyleBackColor = true;
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
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnApply.ForeColor = System.Drawing.Color.Gold;
            this.btnApply.Location = new System.Drawing.Point(14, 45);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(187, 48);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            // ucDefault1
            // 
            this.ucDefault1.Location = new System.Drawing.Point(307, 123);
            this.ucDefault1.Name = "ucDefault1";
            this.ucDefault1.Size = new System.Drawing.Size(786, 468);
            this.ucDefault1.TabIndex = 5;
            // 
            // ucPropertyList1
            // 
            this.ucPropertyList1.Location = new System.Drawing.Point(314, 121);
            this.ucPropertyList1.Name = "ucPropertyList1";
            this.ucPropertyList1.Size = new System.Drawing.Size(768, 453);
            this.ucPropertyList1.TabIndex = 6;
            // 
            // ucApply1
            // 
            this.ucApply1.Location = new System.Drawing.Point(323, 130);
            this.ucApply1.Name = "ucApply1";
            this.ucApply1.Size = new System.Drawing.Size(768, 453);
            this.ucApply1.TabIndex = 7;
            // 
            // frmTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 616);
            this.Controls.Add(this.ucApply1);
            this.Controls.Add(this.ucPropertyList1);
            this.Controls.Add(this.ucDefault1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.frmTenant_Load);
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
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.Panel pnlPropertyType;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnProperty;
        private ucDefault ucDefault1;
        private ucPropertyList ucPropertyList1;
        private ucApply ucApply1;
    }
}