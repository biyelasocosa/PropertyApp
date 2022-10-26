namespace PropertyApp
{
    partial class ucApply
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
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDuration = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imgProperty = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.pnlDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.imgProperty);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.pnlDuration);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.btnRent);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.75F);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental";
            // 
            // dgvRental
            // 
            this.dgvRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(9, 246);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.Size = new System.Drawing.Size(739, 194);
            this.dgvRental.TabIndex = 11;
            this.dgvRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellClick);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(600, 186);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(102, 38);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnRent
            // 
            this.btnRent.ForeColor = System.Drawing.Color.Red;
            this.btnRent.Location = new System.Drawing.Point(489, 186);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(105, 38);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent Now";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Visible = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(90, 73);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(269, 24);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(90, 34);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(269, 24);
            this.dtpStartDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // pnlDuration
            // 
            this.pnlDuration.Controls.Add(this.label2);
            this.pnlDuration.Controls.Add(this.dtpStartDate);
            this.pnlDuration.Controls.Add(this.label3);
            this.pnlDuration.Controls.Add(this.label4);
            this.pnlDuration.Controls.Add(this.dtpEndDate);
            this.pnlDuration.Location = new System.Drawing.Point(31, 106);
            this.pnlDuration.Name = "pnlDuration";
            this.pnlDuration.Size = new System.Drawing.Size(366, 105);
            this.pnlDuration.TabIndex = 11;
            this.pnlDuration.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(148, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 24);
            this.txtSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search for Property";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(370, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 34);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter the Duration:";
            // 
            // imgProperty
            // 
            this.imgProperty.Location = new System.Drawing.Point(482, 13);
            this.imgProperty.Name = "imgProperty";
            this.imgProperty.Size = new System.Drawing.Size(224, 167);
            this.imgProperty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProperty.TabIndex = 15;
            this.imgProperty.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(708, 198);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(12, 16);
            this.lblID.TabIndex = 16;
            this.lblID.Text = ".";
            this.lblID.Visible = false;
            // 
            // ucApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvRental);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucApply";
            this.Size = new System.Drawing.Size(768, 453);
            this.Load += new System.EventHandler(this.ucApply_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.pnlDuration.ResumeLayout(false);
            this.pnlDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgProperty;
        private System.Windows.Forms.Label lblID;
    }
}
