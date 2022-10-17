namespace PropertyApp
{
    partial class ucProperty
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
            this.dgvProperty = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.imgProperty = new System.Windows.Forms.PictureBox();
            this.cmbSurbub = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPropertyType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProperty);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.imgProperty);
            this.groupBox1.Controls.Add(this.cmbSurbub);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbPropertyType);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // dgvProperty
            // 
            this.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperty.Location = new System.Drawing.Point(19, 239);
            this.dgvProperty.Name = "dgvProperty";
            this.dgvProperty.Size = new System.Drawing.Size(715, 188);
            this.dgvProperty.TabIndex = 19;
            this.dgvProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperty_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(394, 193);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(103, 35);
            this.btnList.TabIndex = 17;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(276, 195);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 35);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(660, 125);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(71, 29);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(653, 66);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 31);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // imgProperty
            // 
            this.imgProperty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgProperty.Location = new System.Drawing.Point(431, 32);
            this.imgProperty.Name = "imgProperty";
            this.imgProperty.Size = new System.Drawing.Size(213, 155);
            this.imgProperty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProperty.TabIndex = 12;
            this.imgProperty.TabStop = false;
            // 
            // cmbSurbub
            // 
            this.cmbSurbub.FormattingEnabled = true;
            this.cmbSurbub.Location = new System.Drawing.Point(152, 151);
            this.cmbSurbub.Name = "cmbSurbub";
            this.cmbSurbub.Size = new System.Drawing.Size(244, 24);
            this.cmbSurbub.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(152, 122);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(244, 24);
            this.cmbStatus.TabIndex = 10;
            // 
            // cmbPropertyType
            // 
            this.cmbPropertyType.FormattingEnabled = true;
            this.cmbPropertyType.Location = new System.Drawing.Point(152, 95);
            this.cmbPropertyType.Name = "cmbPropertyType";
            this.cmbPropertyType.Size = new System.Drawing.Size(244, 24);
            this.cmbPropertyType.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(147, 53);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(249, 26);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 23);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Surbub";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Property Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // ucProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucProperty";
            this.Size = new System.Drawing.Size(768, 453);
            this.Load += new System.EventHandler(this.ucProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox imgProperty;
        private System.Windows.Forms.ComboBox cmbSurbub;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPropertyType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProperty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
    }
}
