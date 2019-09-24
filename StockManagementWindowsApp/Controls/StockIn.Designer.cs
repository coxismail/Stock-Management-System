namespace StockManagementWindowsApp.Controls
{
    partial class StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
            this.totalPriceTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemIdHidden = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stockInQuatityTextBox = new System.Windows.Forms.TextBox();
            this.ItemListBox = new System.Windows.Forms.ComboBox();
            this.companyListBox = new System.Windows.Forms.ComboBox();
            this.catagoryListBox = new System.Windows.Forms.ComboBox();
            this.stockinButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.availAbleQuatityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.AutoSize = true;
            this.totalPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(284, 381);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(0, 23);
            this.totalPriceTextBox.TabIndex = 238;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 237;
            this.label2.Text = "Total Price :";
            // 
            // itemIdHidden
            // 
            this.itemIdHidden.AutoSize = true;
            this.itemIdHidden.ForeColor = System.Drawing.SystemColors.Control;
            this.itemIdHidden.Location = new System.Drawing.Point(202, 425);
            this.itemIdHidden.Name = "itemIdHidden";
            this.itemIdHidden.Size = new System.Drawing.Size(0, 17);
            this.itemIdHidden.TabIndex = 236;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(283, 233);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(255, 30);
            this.priceTextBox.TabIndex = 239;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(118, 233);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 23);
            this.label.TabIndex = 235;
            this.label.Text = "Per Pice Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 234;
            this.label1.Text = "Stock In Quantity :";
            // 
            // stockInQuatityTextBox
            // 
            this.stockInQuatityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInQuatityTextBox.Location = new System.Drawing.Point(283, 327);
            this.stockInQuatityTextBox.Name = "stockInQuatityTextBox";
            this.stockInQuatityTextBox.Size = new System.Drawing.Size(255, 30);
            this.stockInQuatityTextBox.TabIndex = 227;
            // 
            // ItemListBox
            // 
            this.ItemListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(283, 186);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(255, 30);
            this.ItemListBox.TabIndex = 226;
            this.ItemListBox.SelectionChangeCommitted += new System.EventHandler(this.ItemListBox_SelectionChangeCommitted);
            // 
            // companyListBox
            // 
            this.companyListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyListBox.FormattingEnabled = true;
            this.companyListBox.Location = new System.Drawing.Point(283, 139);
            this.companyListBox.Name = "companyListBox";
            this.companyListBox.Size = new System.Drawing.Size(255, 30);
            this.companyListBox.TabIndex = 225;
            this.companyListBox.SelectionChangeCommitted += new System.EventHandler(this.companyListBox_SelectionChangeCommitted);
            // 
            // catagoryListBox
            // 
            this.catagoryListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryListBox.FormattingEnabled = true;
            this.catagoryListBox.Location = new System.Drawing.Point(283, 92);
            this.catagoryListBox.Name = "catagoryListBox";
            this.catagoryListBox.Size = new System.Drawing.Size(255, 30);
            this.catagoryListBox.TabIndex = 224;
            this.catagoryListBox.SelectionChangeCommitted += new System.EventHandler(this.catagoryListBox_SelectionChangeCommitted);
            // 
            // stockinButton
            // 
            this.stockinButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stockinButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockinButton.Location = new System.Drawing.Point(412, 412);
            this.stockinButton.Name = "stockinButton";
            this.stockinButton.Size = new System.Drawing.Size(126, 39);
            this.stockinButton.TabIndex = 228;
            this.stockinButton.Text = "Stock In";
            this.stockinButton.UseVisualStyleBackColor = false;
            this.stockinButton.Click += new System.EventHandler(this.stockinButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 233;
            this.label9.Text = "Available Quantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 232;
            this.label8.Text = "Items :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 231;
            this.label7.Text = "Company :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 230;
            this.label6.Text = "Category :";
            // 
            // availAbleQuatityTextBox
            // 
            this.availAbleQuatityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availAbleQuatityTextBox.Location = new System.Drawing.Point(283, 280);
            this.availAbleQuatityTextBox.Name = "availAbleQuatityTextBox";
            this.availAbleQuatityTextBox.ReadOnly = true;
            this.availAbleQuatityTextBox.Size = new System.Drawing.Size(255, 30);
            this.availAbleQuatityTextBox.TabIndex = 240;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(198, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 42);
            this.label5.TabIndex = 229;
            this.label5.Text = "Stock In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 39);
            this.label3.TabIndex = 241;
            this.label3.Text = "     ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemIdHidden);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockInQuatityTextBox);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.companyListBox);
            this.Controls.Add(this.catagoryListBox);
            this.Controls.Add(this.stockinButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.availAbleQuatityTextBox);
            this.Controls.Add(this.label5);
            this.Name = "StockIn";
            this.Size = new System.Drawing.Size(800, 700);
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemIdHidden;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockInQuatityTextBox;
        private System.Windows.Forms.ComboBox ItemListBox;
        private System.Windows.Forms.ComboBox companyListBox;
        private System.Windows.Forms.ComboBox catagoryListBox;
        private System.Windows.Forms.Button stockinButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox availAbleQuatityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}
