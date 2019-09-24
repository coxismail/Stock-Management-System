namespace StockManagementWindowsApp.Controls
{
    partial class CompanySetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySetup));
            this.companyIdHidden = new System.Windows.Forms.Label();
            this.companyGridview = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.companyDeleteButton = new System.Windows.Forms.Button();
            this.CompanyUpdateButton = new System.Windows.Forms.Button();
            this.companySaveButton = new System.Windows.Forms.Button();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCompanyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // companyIdHidden
            // 
            this.companyIdHidden.AutoSize = true;
            this.companyIdHidden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyIdHidden.ForeColor = System.Drawing.Color.PaleGreen;
            this.companyIdHidden.Location = new System.Drawing.Point(190, 133);
            this.companyIdHidden.Name = "companyIdHidden";
            this.companyIdHidden.Size = new System.Drawing.Size(0, 23);
            this.companyIdHidden.TabIndex = 134;
            // 
            // companyGridview
            // 
            this.companyGridview.AllowUserToAddRows = false;
            this.companyGridview.AllowUserToDeleteRows = false;
            this.companyGridview.AllowUserToResizeRows = false;
            this.companyGridview.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.companyGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companyGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.companyGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridview.Location = new System.Drawing.Point(578, 82);
            this.companyGridview.Name = "companyGridview";
            this.companyGridview.ReadOnly = true;
            this.companyGridview.RowHeadersWidth = 4;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyGridview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.companyGridview.RowTemplate.Height = 24;
            this.companyGridview.RowTemplate.ReadOnly = true;
            this.companyGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companyGridview.ShowCellErrors = false;
            this.companyGridview.ShowCellToolTips = false;
            this.companyGridview.ShowEditingIcon = false;
            this.companyGridview.ShowRowErrors = false;
            this.companyGridview.Size = new System.Drawing.Size(486, 565);
            this.companyGridview.TabIndex = 133;
            this.companyGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyGridview_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(187, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 37);
            this.label4.TabIndex = 132;
            this.label4.Text = "Company Setup";
            // 
            // companyDeleteButton
            // 
            this.companyDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.companyDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyDeleteButton.Location = new System.Drawing.Point(224, 125);
            this.companyDeleteButton.Name = "companyDeleteButton";
            this.companyDeleteButton.Size = new System.Drawing.Size(129, 39);
            this.companyDeleteButton.TabIndex = 130;
            this.companyDeleteButton.Text = "Delete";
            this.companyDeleteButton.UseVisualStyleBackColor = false;
            this.companyDeleteButton.Click += new System.EventHandler(this.companyDeleteButton_Click);
            // 
            // CompanyUpdateButton
            // 
            this.CompanyUpdateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CompanyUpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyUpdateButton.Location = new System.Drawing.Point(360, 173);
            this.CompanyUpdateButton.Name = "CompanyUpdateButton";
            this.CompanyUpdateButton.Size = new System.Drawing.Size(126, 43);
            this.CompanyUpdateButton.TabIndex = 129;
            this.CompanyUpdateButton.Text = "Update";
            this.CompanyUpdateButton.UseVisualStyleBackColor = false;
            this.CompanyUpdateButton.Click += new System.EventHandler(this.CompanyUpdateButton_Click);
            // 
            // companySaveButton
            // 
            this.companySaveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.companySaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySaveButton.Location = new System.Drawing.Point(360, 125);
            this.companySaveButton.Name = "companySaveButton";
            this.companySaveButton.Size = new System.Drawing.Size(126, 39);
            this.companySaveButton.TabIndex = 128;
            this.companySaveButton.Text = "Save";
            this.companySaveButton.UseVisualStyleBackColor = false;
            this.companySaveButton.Click += new System.EventHandler(this.companySaveButton_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTextBox.Location = new System.Drawing.Point(224, 81);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(263, 30);
            this.companyTextBox.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 131;
            this.label3.Text = "Company Name :";
            // 
            // totalCompanyLabel
            // 
            this.totalCompanyLabel.AutoSize = true;
            this.totalCompanyLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompanyLabel.Location = new System.Drawing.Point(94, 271);
            this.totalCompanyLabel.Name = "totalCompanyLabel";
            this.totalCompanyLabel.Size = new System.Drawing.Size(0, 25);
            this.totalCompanyLabel.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 39);
            this.label7.TabIndex = 136;
            this.label7.Text = "     ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalCompanyLabel);
            this.Controls.Add(this.companyIdHidden);
            this.Controls.Add(this.companyGridview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companyDeleteButton);
            this.Controls.Add(this.CompanyUpdateButton);
            this.Controls.Add(this.companySaveButton);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.label3);
            this.Name = "CompanySetup";
            this.Size = new System.Drawing.Size(1117, 700);
            this.Load += new System.EventHandler(this.CompanySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyIdHidden;
        private System.Windows.Forms.DataGridView companyGridview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button companyDeleteButton;
        private System.Windows.Forms.Button CompanyUpdateButton;
        private System.Windows.Forms.Button companySaveButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCompanyLabel;
        private System.Windows.Forms.Label label7;
    }
}
