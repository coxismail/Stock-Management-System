namespace StockManagementWindowsApp.Controls
{
    partial class ItemSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSetup));
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.itemsIdHidden = new System.Windows.Forms.Label();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.companyListBox = new System.Windows.Forms.ComboBox();
            this.catagoryListBox = new System.Windows.Forms.ComboBox();
            this.itemDeleteButton = new System.Windows.Forms.Button();
            this.itemUpdateButton = new System.Windows.Forms.Button();
            this.itemSaveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalItemsLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsLabel.Location = new System.Drawing.Point(66, 448);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(0, 25);
            this.totalItemsLabel.TabIndex = 145;
            // 
            // itemsIdHidden
            // 
            this.itemsIdHidden.AutoSize = true;
            this.itemsIdHidden.ForeColor = System.Drawing.SystemColors.Control;
            this.itemsIdHidden.Location = new System.Drawing.Point(100, 257);
            this.itemsIdHidden.Name = "itemsIdHidden";
            this.itemsIdHidden.Size = new System.Drawing.Size(0, 17);
            this.itemsIdHidden.TabIndex = 144;
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.AllowUserToResizeRows = false;
            this.itemsGridView.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.itemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(547, 111);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.itemsGridView.RowHeadersWidth = 4;
            this.itemsGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.itemsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.itemsGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.itemsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.itemsGridView.RowTemplate.Height = 24;
            this.itemsGridView.RowTemplate.ReadOnly = true;
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.ShowCellErrors = false;
            this.itemsGridView.ShowCellToolTips = false;
            this.itemsGridView.ShowEditingIcon = false;
            this.itemsGridView.ShowRowErrors = false;
            this.itemsGridView.Size = new System.Drawing.Size(623, 565);
            this.itemsGridView.TabIndex = 143;
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            // 
            // companyListBox
            // 
            this.companyListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyListBox.FormattingEnabled = true;
            this.companyListBox.Location = new System.Drawing.Point(202, 159);
            this.companyListBox.Name = "companyListBox";
            this.companyListBox.Size = new System.Drawing.Size(293, 30);
            this.companyListBox.TabIndex = 132;
            this.companyListBox.SelectionChangeCommitted += new System.EventHandler(this.companyListBox_SelectionChangeCommitted_1);
            // 
            // catagoryListBox
            // 
            this.catagoryListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryListBox.FormattingEnabled = true;
            this.catagoryListBox.Location = new System.Drawing.Point(202, 108);
            this.catagoryListBox.Name = "catagoryListBox";
            this.catagoryListBox.Size = new System.Drawing.Size(293, 30);
            this.catagoryListBox.TabIndex = 131;
            this.catagoryListBox.SelectionChangeCommitted += new System.EventHandler(this.catagoryListBox_SelectionChangeCommitted);
            // 
            // itemDeleteButton
            // 
            this.itemDeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDeleteButton.Location = new System.Drawing.Point(233, 319);
            this.itemDeleteButton.Name = "itemDeleteButton";
            this.itemDeleteButton.Size = new System.Drawing.Size(129, 39);
            this.itemDeleteButton.TabIndex = 137;
            this.itemDeleteButton.Text = "Delete";
            this.itemDeleteButton.UseVisualStyleBackColor = false;
            this.itemDeleteButton.Click += new System.EventHandler(this.itemDeleteButton_Click);
            // 
            // itemUpdateButton
            // 
            this.itemUpdateButton.BackColor = System.Drawing.SystemColors.Info;
            this.itemUpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemUpdateButton.Location = new System.Drawing.Point(369, 368);
            this.itemUpdateButton.Name = "itemUpdateButton";
            this.itemUpdateButton.Size = new System.Drawing.Size(126, 43);
            this.itemUpdateButton.TabIndex = 136;
            this.itemUpdateButton.Text = "Update";
            this.itemUpdateButton.UseVisualStyleBackColor = false;
            this.itemUpdateButton.Click += new System.EventHandler(this.itemUpdateButton_Click);
            // 
            // itemSaveButton
            // 
            this.itemSaveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemSaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSaveButton.Location = new System.Drawing.Point(369, 319);
            this.itemSaveButton.Name = "itemSaveButton";
            this.itemSaveButton.Size = new System.Drawing.Size(126, 39);
            this.itemSaveButton.TabIndex = 135;
            this.itemSaveButton.Text = "Save";
            this.itemSaveButton.UseVisualStyleBackColor = false;
            this.itemSaveButton.Click += new System.EventHandler(this.itemSaveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 142;
            this.label9.Text = "Price :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 141;
            this.label8.Text = "Items Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 140;
            this.label7.Text = "Company :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 139;
            this.label6.Text = "Category :";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(202, 269);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(293, 30);
            this.itemPriceTextBox.TabIndex = 134;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(202, 217);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(293, 30);
            this.itemNameTextBox.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(188, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 138;
            this.label5.Text = "Items Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 146;
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalItemsLabel);
            this.Controls.Add(this.itemsIdHidden);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.companyListBox);
            this.Controls.Add(this.catagoryListBox);
            this.Controls.Add(this.itemDeleteButton);
            this.Controls.Add(this.itemUpdateButton);
            this.Controls.Add(this.itemSaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label5);
            this.Name = "ItemSetup";
            this.Size = new System.Drawing.Size(1350, 700);
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Label itemsIdHidden;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.ComboBox companyListBox;
        private System.Windows.Forms.ComboBox catagoryListBox;
        private System.Windows.Forms.Button itemDeleteButton;
        private System.Windows.Forms.Button itemUpdateButton;
        private System.Windows.Forms.Button itemSaveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
