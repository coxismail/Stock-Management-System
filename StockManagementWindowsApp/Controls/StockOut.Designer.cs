namespace StockManagementWindowsApp.Controls
{
    partial class StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.mnumberBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.netBillTexBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.vatPriceTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.vatPercentTextBox = new System.Windows.Forms.TextBox();
            this.discountPriceTexBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountPercentTextBox = new System.Windows.Forms.TextBox();
            this.outItemIdHidden = new System.Windows.Forms.Label();
            this.saleButton = new System.Windows.Forms.Button();
            this.lostButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.outTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.outQuantityTextBox = new System.Windows.Forms.TextBox();
            this.addCardButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.availAbleQuatityTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cardTitle = new System.Windows.Forms.Label();
            this.stockOutCard = new System.Windows.Forms.DataGridView();
            this.companyListBox = new System.Windows.Forms.ComboBox();
            this.catagoryListBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutCard)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.okButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(389, 649);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 39);
            this.okButton.TabIndex = 239;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(277, 649);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 39);
            this.cancelButton.TabIndex = 240;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(235, 566);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(255, 42);
            this.addressTextBox.TabIndex = 237;
            this.addressTextBox.Text = "";
            this.addressTextBox.Visible = false;
            // 
            // mnumberBox
            // 
            this.mnumberBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnumberBox.Location = new System.Drawing.Point(235, 615);
            this.mnumberBox.Name = "mnumberBox";
            this.mnumberBox.Size = new System.Drawing.Size(255, 30);
            this.mnumberBox.TabIndex = 238;
            this.mnumberBox.Visible = false;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(235, 532);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(255, 30);
            this.customerNameBox.TabIndex = 235;
            this.customerNameBox.Visible = false;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numberLabel.Location = new System.Drawing.Point(60, 618);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(152, 23);
            this.numberLabel.TabIndex = 261;
            this.numberLabel.Text = "Mobile Number :";
            this.numberLabel.Visible = false;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addLabel.Location = new System.Drawing.Point(122, 577);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(90, 23);
            this.addLabel.TabIndex = 260;
            this.addLabel.Text = "Address :";
            this.addLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameLabel.Location = new System.Drawing.Point(54, 535);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 23);
            this.nameLabel.TabIndex = 259;
            this.nameLabel.Text = "Customer Name :";
            this.nameLabel.Visible = false;
            // 
            // netBillTexBox
            // 
            this.netBillTexBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netBillTexBox.Location = new System.Drawing.Point(235, 408);
            this.netBillTexBox.Name = "netBillTexBox";
            this.netBillTexBox.ReadOnly = true;
            this.netBillTexBox.Size = new System.Drawing.Size(255, 30);
            this.netBillTexBox.TabIndex = 265;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(125, 411);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 23);
            this.label20.TabIndex = 258;
            this.label20.Text = "Net Bill :";
            // 
            // vatPriceTextBox
            // 
            this.vatPriceTextBox.Enabled = false;
            this.vatPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatPriceTextBox.Location = new System.Drawing.Point(377, 372);
            this.vatPriceTextBox.Name = "vatPriceTextBox";
            this.vatPriceTextBox.Size = new System.Drawing.Size(113, 30);
            this.vatPriceTextBox.TabIndex = 257;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(322, 374);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 23);
            this.label18.TabIndex = 256;
            this.label18.Text = "%  =";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(160, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 23);
            this.label19.TabIndex = 255;
            this.label19.Text = "Vat :";
            // 
            // vatPercentTextBox
            // 
            this.vatPercentTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatPercentTextBox.Location = new System.Drawing.Point(235, 371);
            this.vatPercentTextBox.Name = "vatPercentTextBox";
            this.vatPercentTextBox.Size = new System.Drawing.Size(85, 30);
            this.vatPercentTextBox.TabIndex = 254;
            this.vatPercentTextBox.Leave += new System.EventHandler(this.vatPercentTextBox_Leave);
            // 
            // discountPriceTexBox
            // 
            this.discountPriceTexBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPriceTexBox.Location = new System.Drawing.Point(377, 336);
            this.discountPriceTexBox.Name = "discountPriceTexBox";
            this.discountPriceTexBox.Size = new System.Drawing.Size(113, 30);
            this.discountPriceTexBox.TabIndex = 253;
            this.discountPriceTexBox.Leave += new System.EventHandler(this.discountPriceTexBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(322, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 23);
            this.label10.TabIndex = 252;
            this.label10.Text = "%  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 251;
            this.label3.Text = "Discount :";
            // 
            // discountPercentTextBox
            // 
            this.discountPercentTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountPercentTextBox.Location = new System.Drawing.Point(235, 335);
            this.discountPercentTextBox.Name = "discountPercentTextBox";
            this.discountPercentTextBox.Size = new System.Drawing.Size(85, 30);
            this.discountPercentTextBox.TabIndex = 250;
            this.discountPercentTextBox.Leave += new System.EventHandler(this.discountPercentTextBox_Leave);
            // 
            // outItemIdHidden
            // 
            this.outItemIdHidden.AutoSize = true;
            this.outItemIdHidden.ForeColor = System.Drawing.SystemColors.Control;
            this.outItemIdHidden.Location = new System.Drawing.Point(232, 462);
            this.outItemIdHidden.Name = "outItemIdHidden";
            this.outItemIdHidden.Size = new System.Drawing.Size(0, 17);
            this.outItemIdHidden.TabIndex = 249;
            // 
            // saleButton
            // 
            this.saleButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saleButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleButton.Location = new System.Drawing.Point(409, 490);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(81, 39);
            this.saleButton.TabIndex = 233;
            this.saleButton.Text = "Sale";
            this.saleButton.UseVisualStyleBackColor = false;
            this.saleButton.Visible = false;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // lostButton
            // 
            this.lostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lostButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostButton.Location = new System.Drawing.Point(326, 490);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(77, 39);
            this.lostButton.TabIndex = 234;
            this.lostButton.Text = "Lost";
            this.lostButton.UseVisualStyleBackColor = false;
            this.lostButton.Visible = false;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.damageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageButton.Location = new System.Drawing.Point(209, 490);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(111, 39);
            this.damageButton.TabIndex = 236;
            this.damageButton.Text = "Damaged";
            this.damageButton.UseVisualStyleBackColor = false;
            this.damageButton.Visible = false;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // outTotalPriceTextBox
            // 
            this.outTotalPriceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTotalPriceTextBox.Location = new System.Drawing.Point(235, 300);
            this.outTotalPriceTextBox.Name = "outTotalPriceTextBox";
            this.outTotalPriceTextBox.ReadOnly = true;
            this.outTotalPriceTextBox.Size = new System.Drawing.Size(255, 30);
            this.outTotalPriceTextBox.TabIndex = 264;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 248;
            this.label4.Text = "Total Price :";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(235, 189);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(255, 30);
            this.priceTextBox.TabIndex = 262;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 247;
            this.label11.Text = "Each Item Price :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 246;
            this.label12.Text = "Quantity :";
            // 
            // outQuantityTextBox
            // 
            this.outQuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outQuantityTextBox.Location = new System.Drawing.Point(235, 263);
            this.outQuantityTextBox.Name = "outQuantityTextBox";
            this.outQuantityTextBox.Size = new System.Drawing.Size(255, 30);
            this.outQuantityTextBox.TabIndex = 231;
            this.outQuantityTextBox.Leave += new System.EventHandler(this.outQuantityTextBox_Leave);
            // 
            // addCardButton
            // 
            this.addCardButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addCardButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardButton.Location = new System.Drawing.Point(326, 445);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(164, 39);
            this.addCardButton.TabIndex = 232;
            this.addCardButton.Text = "Add To Card";
            this.addCardButton.UseVisualStyleBackColor = false;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 23);
            this.label13.TabIndex = 245;
            this.label13.Text = "Available Quantity :";
            // 
            // availAbleQuatityTextBox
            // 
            this.availAbleQuatityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availAbleQuatityTextBox.Location = new System.Drawing.Point(235, 226);
            this.availAbleQuatityTextBox.Name = "availAbleQuatityTextBox";
            this.availAbleQuatityTextBox.ReadOnly = true;
            this.availAbleQuatityTextBox.Size = new System.Drawing.Size(255, 30);
            this.availAbleQuatityTextBox.TabIndex = 263;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(174, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 37);
            this.label17.TabIndex = 241;
            this.label17.Text = "Stock Out";
            // 
            // cardTitle
            // 
            this.cardTitle.AutoSize = true;
            this.cardTitle.Font = new System.Drawing.Font("Times New Roman", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cardTitle.Location = new System.Drawing.Point(570, 63);
            this.cardTitle.Name = "cardTitle";
            this.cardTitle.Size = new System.Drawing.Size(0, 37);
            this.cardTitle.TabIndex = 267;
            // 
            // stockOutCard
            // 
            this.stockOutCard.AllowUserToAddRows = false;
            this.stockOutCard.AllowUserToDeleteRows = false;
            this.stockOutCard.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.stockOutCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockOutCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockOutCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockOutCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutCard.GridColor = System.Drawing.Color.White;
            this.stockOutCard.Location = new System.Drawing.Point(528, 125);
            this.stockOutCard.Name = "stockOutCard";
            this.stockOutCard.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockOutCard.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stockOutCard.RowHeadersWidth = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            this.stockOutCard.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.stockOutCard.RowTemplate.Height = 24;
            this.stockOutCard.Size = new System.Drawing.Size(753, 587);
            this.stockOutCard.TabIndex = 266;
            this.stockOutCard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockOutCard_CellDoubleClick);
            // 
            // companyListBox
            // 
            this.companyListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyListBox.FormattingEnabled = true;
            this.companyListBox.Location = new System.Drawing.Point(235, 83);
            this.companyListBox.Name = "companyListBox";
            this.companyListBox.Size = new System.Drawing.Size(255, 30);
            this.companyListBox.TabIndex = 269;
            this.companyListBox.SelectionChangeCommitted += new System.EventHandler(this.companyListBox_SelectionChangeCommitted);
            // 
            // catagoryListBox
            // 
            this.catagoryListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryListBox.FormattingEnabled = true;
            this.catagoryListBox.Location = new System.Drawing.Point(235, 46);
            this.catagoryListBox.Name = "catagoryListBox";
            this.catagoryListBox.Size = new System.Drawing.Size(255, 30);
            this.catagoryListBox.TabIndex = 268;
            this.catagoryListBox.SelectionChangeCommitted += new System.EventHandler(this.catagoryListBox_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 273;
            this.label8.Text = "Items Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 272;
            this.label7.Text = "Company :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 271;
            this.label6.Text = "Category :";
            // 
            // ItemListBox
            // 
            this.ItemListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(234, 119);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(255, 30);
            this.ItemListBox.TabIndex = 274;
            this.ItemListBox.SelectionChangeCommitted += new System.EventHandler(this.ItemListBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 275;
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.Location = new System.Drawing.Point(235, 154);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(255, 30);
            this.modelBox.TabIndex = 277;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 276;
            this.label2.Text = "Serial/ Model :";
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.companyListBox);
            this.Controls.Add(this.catagoryListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cardTitle);
            this.Controls.Add(this.stockOutCard);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mnumberBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.netBillTexBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.vatPriceTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.vatPercentTextBox);
            this.Controls.Add(this.discountPriceTexBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discountPercentTextBox);
            this.Controls.Add(this.outItemIdHidden);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.lostButton);
            this.Controls.Add(this.damageButton);
            this.Controls.Add(this.outTotalPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.outQuantityTextBox);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.availAbleQuatityTextBox);
            this.Controls.Add(this.label17);
            this.Name = "StockOut";
            this.Size = new System.Drawing.Size(1350, 768);
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.TextBox mnumberBox;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox netBillTexBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox vatPriceTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox vatPercentTextBox;
        private System.Windows.Forms.TextBox discountPriceTexBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox discountPercentTextBox;
        private System.Windows.Forms.Label outItemIdHidden;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.TextBox outTotalPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox outQuantityTextBox;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox availAbleQuatityTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label cardTitle;
        private System.Windows.Forms.DataGridView stockOutCard;
        private System.Windows.Forms.ComboBox companyListBox;
        private System.Windows.Forms.ComboBox catagoryListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ItemListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.Label label2;
    }
}
