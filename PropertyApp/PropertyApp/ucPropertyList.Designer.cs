namespace PropertyApp
{
    partial class ucPropertyList
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvPropertyList = new System.Windows.Forms.DataGridView();
            this.imgProperty = new System.Windows.Forms.PictureBox();
            this.lblPropertyType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSurbub = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblSurbub);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPropertyType);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.dgvPropertyList);
            this.groupBox1.Controls.Add(this.imgProperty);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.75F);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property List";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(187, 228);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = ".";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(187, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(12, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = ".";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(187, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(12, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = ".";
            // 
            // dgvPropertyList
            // 
            this.dgvPropertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyList.Location = new System.Drawing.Point(42, 293);
            this.dgvPropertyList.Name = "dgvPropertyList";
            this.dgvPropertyList.Size = new System.Drawing.Size(681, 143);
            this.dgvPropertyList.TabIndex = 2;
            this.dgvPropertyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropertyList_CellClick);
            // 
            // imgProperty
            // 
            this.imgProperty.BackColor = System.Drawing.SystemColors.HighlightText;
            this.imgProperty.Location = new System.Drawing.Point(326, 15);
            this.imgProperty.Name = "imgProperty";
            this.imgProperty.Size = new System.Drawing.Size(348, 270);
            this.imgProperty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProperty.TabIndex = 1;
            this.imgProperty.TabStop = false;
            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Location = new System.Drawing.Point(187, 146);
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(12, 16);
            this.lblPropertyType.TabIndex = 9;
            this.lblPropertyType.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Property Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Surbub:";
            // 
            // lblSurbub
            // 
            this.lblSurbub.AutoSize = true;
            this.lblSurbub.Location = new System.Drawing.Point(187, 188);
            this.lblSurbub.Name = "lblSurbub";
            this.lblSurbub.Size = new System.Drawing.Size(12, 16);
            this.lblSurbub.TabIndex = 14;
            this.lblSurbub.Text = ".";
            // 
            // ucPropertyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPropertyList";
            this.Size = new System.Drawing.Size(768, 456);
            this.Load += new System.EventHandler(this.ucPropertyList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgProperty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgvPropertyList;
        private System.Windows.Forms.Label lblPropertyType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSurbub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
