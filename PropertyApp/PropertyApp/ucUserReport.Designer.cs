namespace PropertyApp
{
    partial class ucUserReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnDisplayUser = new System.Windows.Forms.Button();
            this.cmbUserStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSoft = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "List Selected User Type:";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(506, 91);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(247, 24);
            this.cmbUserType.TabIndex = 8;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // btnDisplayUser
            // 
            this.btnDisplayUser.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayUser.Location = new System.Drawing.Point(292, 131);
            this.btnDisplayUser.Name = "btnDisplayUser";
            this.btnDisplayUser.Size = new System.Drawing.Size(132, 38);
            this.btnDisplayUser.TabIndex = 7;
            this.btnDisplayUser.Text = "Display";
            this.btnDisplayUser.UseVisualStyleBackColor = true;
            this.btnDisplayUser.Click += new System.EventHandler(this.btnDisplayUser_Click);
            // 
            // cmbUserStatus
            // 
            this.cmbUserStatus.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.cmbUserStatus.FormattingEnabled = true;
            this.cmbUserStatus.Location = new System.Drawing.Point(177, 90);
            this.cmbUserStatus.Name = "cmbUserStatus";
            this.cmbUserStatus.Size = new System.Drawing.Size(247, 24);
            this.cmbUserStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter User By Status:\r\n";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(18, 223);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(846, 224);
            this.dgvReport.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHard);
            this.groupBox1.Controls.Add(this.btnSoft);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUserStatus);
            this.groupBox1.Controls.Add(this.btnDisplayUser);
            this.groupBox1.Controls.Add(this.cmbUserType);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // btnSoft
            // 
            this.btnSoft.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoft.Location = new System.Drawing.Point(38, 64);
            this.btnSoft.Name = "btnSoft";
            this.btnSoft.Size = new System.Drawing.Size(105, 33);
            this.btnSoft.TabIndex = 10;
            this.btnSoft.Text = "Soft Delete";
            this.btnSoft.UseVisualStyleBackColor = true;
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(34, 115);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(109, 32);
            this.btnHard.TabIndex = 11;
            this.btnHard.Text = "Hard Delete";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // ucUserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReport);
            this.Name = "ucUserReport";
            this.Size = new System.Drawing.Size(882, 462);
            this.Load += new System.EventHandler(this.ucUserReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnDisplayUser;
        private System.Windows.Forms.ComboBox cmbUserStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnSoft;
    }
}
