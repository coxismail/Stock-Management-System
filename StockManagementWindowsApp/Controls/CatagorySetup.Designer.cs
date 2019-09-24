namespace StockManagementWindowsApp.Controls
{
    partial class CatagorySetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatagorySetup));
            this.idhiddenLabel = new System.Windows.Forms.Label();
            this.catagoryDeleteButton = new System.Windows.Forms.Button();
            this.CatagoryUpdateButton = new System.Windows.Forms.Button();
            this.catagoryGridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.catagorySaveButton = new System.Windows.Forms.Button();
            this.catagoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCatagoryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // idhiddenLabel
            // 
            this.idhiddenLabel.AutoSize = true;
            this.idhiddenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idhiddenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.idhiddenLabel.Location = new System.Drawing.Point(184, 110);
            this.idhiddenLabel.Name = "idhiddenLabel";
            this.idhiddenLabel.Size = new System.Drawing.Size(0, 23);
            this.idhiddenLabel.TabIndex = 129;
            // 
            // catagoryDeleteButton
            // 
            this.catagoryDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.catagoryDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryDeleteButton.Location = new System.Drawing.Point(231, 128);
            this.catagoryDeleteButton.Name = "catagoryDeleteButton";
            this.catagoryDeleteButton.Size = new System.Drawing.Size(111, 40);
            this.catagoryDeleteButton.TabIndex = 127;
            this.catagoryDeleteButton.Text = "Delete";
            this.catagoryDeleteButton.UseVisualStyleBackColor = false;
            this.catagoryDeleteButton.Click += new System.EventHandler(this.catagoryDeleteButton_Click);
            // 
            // CatagoryUpdateButton
            // 
            this.CatagoryUpdateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CatagoryUpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryUpdateButton.Location = new System.Drawing.Point(349, 178);
            this.CatagoryUpdateButton.Name = "CatagoryUpdateButton";
            this.CatagoryUpdateButton.Size = new System.Drawing.Size(119, 43);
            this.CatagoryUpdateButton.TabIndex = 126;
            this.CatagoryUpdateButton.Text = "Update";
            this.CatagoryUpdateButton.UseVisualStyleBackColor = false;
            this.CatagoryUpdateButton.Click += new System.EventHandler(this.CatagoryUpdateButton_Click);
            // 
            // catagoryGridview
            // 
            this.catagoryGridview.AllowUserToAddRows = false;
            this.catagoryGridview.AllowUserToDeleteRows = false;
            this.catagoryGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catagoryGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.catagoryGridview.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.catagoryGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catagoryGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.catagoryGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catagoryGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catagoryGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catagoryGridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catagoryGridview.Location = new System.Drawing.Point(541, 82);
            this.catagoryGridview.Name = "catagoryGridview";
            this.catagoryGridview.ReadOnly = true;
            this.catagoryGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catagoryGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.catagoryGridview.RowHeadersWidth = 4;
            this.catagoryGridview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryGridview.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.catagoryGridview.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.catagoryGridview.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.catagoryGridview.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.catagoryGridview.RowTemplate.Height = 24;
            this.catagoryGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catagoryGridview.ShowCellErrors = false;
            this.catagoryGridview.ShowCellToolTips = false;
            this.catagoryGridview.ShowEditingIcon = false;
            this.catagoryGridview.ShowRowErrors = false;
            this.catagoryGridview.Size = new System.Drawing.Size(491, 583);
            this.catagoryGridview.TabIndex = 130;
            this.catagoryGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catagoryGridview_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(426, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 128;
            this.label2.Text = "Category Setup";
            // 
            // catagorySaveButton
            // 
            this.catagorySaveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.catagorySaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagorySaveButton.Location = new System.Drawing.Point(349, 128);
            this.catagorySaveButton.Name = "catagorySaveButton";
            this.catagorySaveButton.Size = new System.Drawing.Size(119, 40);
            this.catagorySaveButton.TabIndex = 125;
            this.catagorySaveButton.Text = "Save";
            this.catagorySaveButton.UseVisualStyleBackColor = false;
            this.catagorySaveButton.Click += new System.EventHandler(this.catagorySaveButton_Click);
            // 
            // catagoryTextBox
            // 
            this.catagoryTextBox.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryTextBox.Location = new System.Drawing.Point(213, 82);
            this.catagoryTextBox.Name = "catagoryTextBox";
            this.catagoryTextBox.Size = new System.Drawing.Size(255, 32);
            this.catagoryTextBox.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 124;
            this.label1.Text = "Category Name :";
            // 
            // totalCatagoryLabel
            // 
            this.totalCatagoryLabel.AutoSize = true;
            this.totalCatagoryLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCatagoryLabel.Location = new System.Drawing.Point(88, 235);
            this.totalCatagoryLabel.Name = "totalCatagoryLabel";
            this.totalCatagoryLabel.Size = new System.Drawing.Size(0, 25);
            this.totalCatagoryLabel.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 39);
            this.label7.TabIndex = 132;
            this.label7.Text = "     ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CatagorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalCatagoryLabel);
            this.Controls.Add(this.idhiddenLabel);
            this.Controls.Add(this.catagoryDeleteButton);
            this.Controls.Add(this.CatagoryUpdateButton);
            this.Controls.Add(this.catagoryGridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catagorySaveButton);
            this.Controls.Add(this.catagoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CatagorySetup";
            this.Size = new System.Drawing.Size(1096, 700);
            this.Load += new System.EventHandler(this.CatagorySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catagoryGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idhiddenLabel;
        private System.Windows.Forms.Button catagoryDeleteButton;
        private System.Windows.Forms.Button CatagoryUpdateButton;
        private System.Windows.Forms.DataGridView catagoryGridview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button catagorySaveButton;
        private System.Windows.Forms.TextBox catagoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCatagoryLabel;
        private System.Windows.Forms.Label label7;
    }
}
