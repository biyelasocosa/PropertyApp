namespace PropertyApp
{
    partial class ucLocationReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.txtSurbub = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProvince = new System.Windows.Forms.Button();
            this.btnSurbub = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSearchCity);
            this.groupBox1.Controls.Add(this.txtSurbub);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProvince);
            this.groupBox1.Controls.Add(this.btnSurbub);
            this.groupBox1.Controls.Add(this.btnCity);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 218);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(423, 50);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(295, 24);
            this.cmbProvince.TabIndex = 17;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Location = new System.Drawing.Point(646, 93);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(89, 34);
            this.btnSearchCity.TabIndex = 15;
            this.btnSearchCity.Text = "Search";
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // txtSurbub
            // 
            this.txtSurbub.Location = new System.Drawing.Point(408, 147);
            this.txtSurbub.Name = "txtSurbub";
            this.txtSurbub.Size = new System.Drawing.Size(230, 26);
            this.txtSurbub.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(408, 97);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(229, 26);
            this.txtCity.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Province";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Surbub";
            // 
            // btnProvince
            // 
            this.btnProvince.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvince.Location = new System.Drawing.Point(60, 138);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(147, 38);
            this.btnProvince.TabIndex = 9;
            this.btnProvince.Text = "List Province";
            this.btnProvince.UseVisualStyleBackColor = true;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click);
            // 
            // btnSurbub
            // 
            this.btnSurbub.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurbub.Location = new System.Drawing.Point(60, 45);
            this.btnSurbub.Name = "btnSurbub";
            this.btnSurbub.Size = new System.Drawing.Size(147, 38);
            this.btnSurbub.TabIndex = 8;
            this.btnSurbub.Text = "List Surbub";
            this.btnSurbub.UseVisualStyleBackColor = true;
            this.btnSurbub.Click += new System.EventHandler(this.btnSurbub_Click);
            // 
            // btnCity
            // 
            this.btnCity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.Location = new System.Drawing.Point(60, 91);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(147, 38);
            this.btnCity.TabIndex = 7;
            this.btnCity.Text = "List City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(16, 227);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(846, 224);
            this.dgvReport.TabIndex = 11;
            // 
            // ucLocationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReport);
            this.Name = "ucLocationReport";
            this.Size = new System.Drawing.Size(882, 462);
            this.Load += new System.EventHandler(this.ucLocationReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProvince;
        private System.Windows.Forms.Button btnSurbub;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSurbub;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button button1;
    }
}
