namespace PropertyApp
{
    partial class ucPropertyReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListAll = new System.Windows.Forms.Button();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchProperty = new System.Windows.Forms.Button();
            this.btnListPropertyType = new System.Windows.Forms.Button();
            this.imgProperty = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(18, 227);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(835, 219);
            this.dgvReport.TabIndex = 5;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Description:";
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(45, 116);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(106, 36);
            this.btnListAll.TabIndex = 1;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnList_Click);
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.FormattingEnabled = true;
            this.cmbPropertyType.Location = new System.Drawing.Point(317, 72);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(252, 26);
            this.cmbPropertyType.TabIndex = 2;
            this.cmbPropertyType.SelectedIndexChanged += new System.EventHandler(this.cmbPropertyType_SelectedIndexChanged);
            // 
            // txtProperty
            // 
            this.txtProperty.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.txtProperty.Location = new System.Drawing.Point(47, 71);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(236, 26);
            this.txtProperty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Display By Property Type";
            // 
            // btnSearchProperty
            // 
            this.btnSearchProperty.Location = new System.Drawing.Point(170, 116);
            this.btnSearchProperty.Name = "btnSearchProperty";
            this.btnSearchProperty.Size = new System.Drawing.Size(104, 36);
            this.btnSearchProperty.TabIndex = 5;
            this.btnSearchProperty.Text = "Search";
            this.btnSearchProperty.UseVisualStyleBackColor = true;
            this.btnSearchProperty.Click += new System.EventHandler(this.btnSearchProperty_Click);
            // 
            // btnListPropertyType
            // 
            this.btnListPropertyType.Location = new System.Drawing.Point(440, 108);
            this.btnListPropertyType.Name = "btnListPropertyType";
            this.btnListPropertyType.Size = new System.Drawing.Size(109, 33);
            this.btnListPropertyType.TabIndex = 6;
            this.btnListPropertyType.Text = "Display All";
            this.btnListPropertyType.UseVisualStyleBackColor = true;
            this.btnListPropertyType.Click += new System.EventHandler(this.btnListPropertyType_Click);
            // 
            // imgProperty
            // 
            this.imgProperty.Location = new System.Drawing.Point(589, 19);
            this.imgProperty.Name = "imgProperty";
            this.imgProperty.Size = new System.Drawing.Size(222, 181);
            this.imgProperty.TabIndex = 7;
            this.imgProperty.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Property Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPropertyType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imgProperty);
            this.groupBox1.Controls.Add(this.btnListAll);
            this.groupBox1.Controls.Add(this.btnListPropertyType);
            this.groupBox1.Controls.Add(this.btnSearchProperty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // ucPropertyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReport);
            this.Name = "ucPropertyReport";
            this.Size = new System.Drawing.Size(882, 462);
            this.Load += new System.EventHandler(this.ucPropertyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProperty;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgProperty;
        private System.Windows.Forms.Button btnListPropertyType;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
