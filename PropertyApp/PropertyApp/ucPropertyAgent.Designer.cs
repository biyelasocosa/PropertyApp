namespace PropertyApp
{
    partial class ucPropertyAgent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPropertyAgent = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.dgvPropertyAgent);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cmbAgent);
            this.groupBox1.Controls.Add(this.cmbProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.75F);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Agent";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Property";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // cmbProperty
            // 
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(277, 37);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(246, 23);
            this.cmbProperty.TabIndex = 4;
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(277, 78);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(246, 23);
            this.cmbAgent.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(277, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(284, 24);
            this.dtpDate.TabIndex = 6;
            // 
            // dgvPropertyAgent
            // 
            this.dgvPropertyAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyAgent.Location = new System.Drawing.Point(48, 218);
            this.dgvPropertyAgent.Name = "dgvPropertyAgent";
            this.dgvPropertyAgent.Size = new System.Drawing.Size(643, 183);
            this.dgvPropertyAgent.TabIndex = 8;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(376, 166);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(118, 38);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucPropertyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPropertyAgent";
            this.Size = new System.Drawing.Size(768, 453);
            this.Load += new System.EventHandler(this.ucPropertyAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dgvPropertyAgent;
    }
}
