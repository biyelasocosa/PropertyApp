﻿namespace PropertyApp
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSurbub = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnAgency = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPropertyType = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ucAgent1 = new PropertyApp.ucAgent();
            this.ucAgency1 = new PropertyApp.ucAgency();
            this.ucSurbub1 = new PropertyApp.ucSurbub();
            this.ucCity1 = new PropertyApp.ucCity();
            this.ucProvince1 = new PropertyApp.ucProvince();
            this.ucProperty1 = new PropertyApp.ucProperty();
            this.ucPropertyType1 = new PropertyApp.ucPropertyType();
            this.pnlPropertyType = new System.Windows.Forms.Panel();
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.pnlProvince = new System.Windows.Forms.Panel();
            this.pnlCity = new System.Windows.Forms.Panel();
            this.pnlSurbub = new System.Windows.Forms.Panel();
            this.pnlAgency = new System.Windows.Forms.Panel();
            this.pnlAgent = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 106);
            this.panel1.TabIndex = 0;
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pnlLogout);
            this.panel2.Controls.Add(this.pnlAgent);
            this.panel2.Controls.Add(this.pnlAgency);
            this.panel2.Controls.Add(this.pnlSurbub);
            this.panel2.Controls.Add(this.pnlCity);
            this.panel2.Controls.Add(this.pnlProvince);
            this.panel2.Controls.Add(this.pnlProperty);
            this.panel2.Controls.Add(this.pnlPropertyType);
            this.panel2.Controls.Add(this.btnSurbub);
            this.panel2.Controls.Add(this.btnCity);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnAgent);
            this.panel2.Controls.Add(this.btnAgency);
            this.panel2.Controls.Add(this.btnProvince);
            this.panel2.Controls.Add(this.btnProperty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnPropertyType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 485);
            this.panel2.TabIndex = 1;
            // 
            // btnSurbub
            // 
            this.btnSurbub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurbub.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnSurbub.ForeColor = System.Drawing.Color.Gold;
            this.btnSurbub.Location = new System.Drawing.Point(14, 246);
            this.btnSurbub.Name = "btnSurbub";
            this.btnSurbub.Size = new System.Drawing.Size(187, 48);
            this.btnSurbub.TabIndex = 8;
            this.btnSurbub.Text = "Surbub";
            this.btnSurbub.UseVisualStyleBackColor = true;
            this.btnSurbub.Click += new System.EventHandler(this.btnSurbub_Click);
            // 
            // btnCity
            // 
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnCity.ForeColor = System.Drawing.Color.Gold;
            this.btnCity.Location = new System.Drawing.Point(14, 196);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(187, 48);
            this.btnCity.TabIndex = 7;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.Gold;
            this.btnLog.Location = new System.Drawing.Point(14, 400);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(187, 48);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Logout";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnAgent.ForeColor = System.Drawing.Color.Gold;
            this.btnAgent.Location = new System.Drawing.Point(14, 348);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(187, 48);
            this.btnAgent.TabIndex = 5;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnAgency
            // 
            this.btnAgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgency.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnAgency.ForeColor = System.Drawing.Color.Gold;
            this.btnAgency.Location = new System.Drawing.Point(14, 297);
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.Size = new System.Drawing.Size(187, 48);
            this.btnAgency.TabIndex = 4;
            this.btnAgency.Text = "Agency";
            this.btnAgency.UseVisualStyleBackColor = true;
            this.btnAgency.Click += new System.EventHandler(this.btnAgency_Click);
            // 
            // btnProvince
            // 
            this.btnProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvince.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnProvince.ForeColor = System.Drawing.Color.Gold;
            this.btnProvince.Location = new System.Drawing.Point(14, 145);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(187, 48);
            this.btnProvince.TabIndex = 3;
            this.btnProvince.Text = "Province";
            this.btnProvince.UseVisualStyleBackColor = true;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click);
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
            // btnPropertyType
            // 
            this.btnPropertyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropertyType.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnPropertyType.ForeColor = System.Drawing.Color.Gold;
            this.btnPropertyType.Location = new System.Drawing.Point(14, 45);
            this.btnPropertyType.Name = "btnPropertyType";
            this.btnPropertyType.Size = new System.Drawing.Size(187, 48);
            this.btnPropertyType.TabIndex = 0;
            this.btnPropertyType.Text = "Property Type";
            this.btnPropertyType.UseVisualStyleBackColor = true;
            this.btnPropertyType.Click += new System.EventHandler(this.btnPropertyType_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(208, 579);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 12);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1085, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 473);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ucAgent1);
            this.panel6.Controls.Add(this.ucAgency1);
            this.panel6.Controls.Add(this.ucSurbub1);
            this.panel6.Controls.Add(this.ucCity1);
            this.panel6.Controls.Add(this.ucProvince1);
            this.panel6.Controls.Add(this.ucProperty1);
            this.panel6.Controls.Add(this.ucPropertyType1);
            this.panel6.Location = new System.Drawing.Point(280, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(768, 453);
            this.panel6.TabIndex = 4;
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
            // ucAgent1
            // 
            this.ucAgent1.Location = new System.Drawing.Point(30, 5);
            this.ucAgent1.Name = "ucAgent1";
            this.ucAgent1.Size = new System.Drawing.Size(768, 453);
            this.ucAgent1.TabIndex = 6;
            // 
            // ucAgency1
            // 
            this.ucAgency1.Location = new System.Drawing.Point(16, -1);
            this.ucAgency1.Name = "ucAgency1";
            this.ucAgency1.Size = new System.Drawing.Size(768, 453);
            this.ucAgency1.TabIndex = 5;
            // 
            // ucSurbub1
            // 
            this.ucSurbub1.Location = new System.Drawing.Point(5, 3);
            this.ucSurbub1.Name = "ucSurbub1";
            this.ucSurbub1.Size = new System.Drawing.Size(768, 453);
            this.ucSurbub1.TabIndex = 4;
            // 
            // ucCity1
            // 
            this.ucCity1.Location = new System.Drawing.Point(4, 1);
            this.ucCity1.Name = "ucCity1";
            this.ucCity1.Size = new System.Drawing.Size(768, 453);
            this.ucCity1.TabIndex = 3;
            // 
            // ucProvince1
            // 
            this.ucProvince1.Location = new System.Drawing.Point(2, 10);
            this.ucProvince1.Name = "ucProvince1";
            this.ucProvince1.Size = new System.Drawing.Size(768, 453);
            this.ucProvince1.TabIndex = 2;
            // 
            // ucProperty1
            // 
            this.ucProperty1.Location = new System.Drawing.Point(2, 13);
            this.ucProperty1.Name = "ucProperty1";
            this.ucProperty1.Size = new System.Drawing.Size(768, 453);
            this.ucProperty1.TabIndex = 1;
            // 
            // ucPropertyType1
            // 
            this.ucPropertyType1.Location = new System.Drawing.Point(0, 0);
            this.ucPropertyType1.Name = "ucPropertyType1";
            this.ucPropertyType1.Size = new System.Drawing.Size(768, 453);
            this.ucPropertyType1.TabIndex = 0;
            // 
            // pnlPropertyType
            // 
            this.pnlPropertyType.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlPropertyType.Location = new System.Drawing.Point(3, 45);
            this.pnlPropertyType.Name = "pnlPropertyType";
            this.pnlPropertyType.Size = new System.Drawing.Size(10, 47);
            this.pnlPropertyType.TabIndex = 9;
            // 
            // pnlProperty
            // 
            this.pnlProperty.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlProperty.Location = new System.Drawing.Point(3, 95);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(10, 47);
            this.pnlProperty.TabIndex = 10;
            // 
            // pnlProvince
            // 
            this.pnlProvince.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlProvince.Location = new System.Drawing.Point(3, 145);
            this.pnlProvince.Name = "pnlProvince";
            this.pnlProvince.Size = new System.Drawing.Size(10, 47);
            this.pnlProvince.TabIndex = 11;
            // 
            // pnlCity
            // 
            this.pnlCity.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlCity.Location = new System.Drawing.Point(3, 196);
            this.pnlCity.Name = "pnlCity";
            this.pnlCity.Size = new System.Drawing.Size(10, 47);
            this.pnlCity.TabIndex = 10;
            // 
            // pnlSurbub
            // 
            this.pnlSurbub.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlSurbub.Location = new System.Drawing.Point(3, 246);
            this.pnlSurbub.Name = "pnlSurbub";
            this.pnlSurbub.Size = new System.Drawing.Size(10, 47);
            this.pnlSurbub.TabIndex = 10;
            // 
            // pnlAgency
            // 
            this.pnlAgency.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAgency.Location = new System.Drawing.Point(3, 298);
            this.pnlAgency.Name = "pnlAgency";
            this.pnlAgency.Size = new System.Drawing.Size(10, 47);
            this.pnlAgency.TabIndex = 10;
            // 
            // pnlAgent
            // 
            this.pnlAgent.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAgent.Location = new System.Drawing.Point(3, 349);
            this.pnlAgent.Name = "pnlAgent";
            this.pnlAgent.Size = new System.Drawing.Size(10, 47);
            this.pnlAgent.TabIndex = 10;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLogout.Location = new System.Drawing.Point(3, 400);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(10, 47);
            this.pnlLogout.TabIndex = 10;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1097, 591);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPropertyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnAgency;
        private System.Windows.Forms.Button btnProvince;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Panel panel6;
        private ucPropertyType ucPropertyType1;
        private ucProperty ucProperty1;
        private System.Windows.Forms.Button btnSurbub;
        private System.Windows.Forms.Button btnCity;
        private ucProvince ucProvince1;
        private ucCity ucCity1;
        private ucSurbub ucSurbub1;
        private System.Windows.Forms.Label label3;
        private ucAgent ucAgent1;
        private ucAgency ucAgency1;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Panel pnlAgent;
        private System.Windows.Forms.Panel pnlAgency;
        private System.Windows.Forms.Panel pnlSurbub;
        private System.Windows.Forms.Panel pnlCity;
        private System.Windows.Forms.Panel pnlProvince;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.Panel pnlPropertyType;
    }
}
