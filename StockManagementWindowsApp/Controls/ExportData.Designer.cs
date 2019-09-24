namespace StockManagementWindowsApp.Controls
{
    partial class ExportData
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
            this.itemsGridview = new System.Windows.Forms.DataGridView();
            this.salseGridview = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salseGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsGridview
            // 
            this.itemsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridview.Location = new System.Drawing.Point(27, 254);
            this.itemsGridview.Name = "itemsGridview";
            this.itemsGridview.RowTemplate.Height = 24;
            this.itemsGridview.Size = new System.Drawing.Size(410, 150);
            this.itemsGridview.TabIndex = 0;
            // 
            // salseGridview
            // 
            this.salseGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salseGridview.Location = new System.Drawing.Point(753, 254);
            this.salseGridview.Name = "salseGridview";
            this.salseGridview.Size = new System.Drawing.Size(442, 150);
            this.salseGridview.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exportButton.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.Transparent;
            this.exportButton.Location = new System.Drawing.Point(485, 267);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(230, 125);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.salseGridview);
            this.Controls.Add(this.itemsGridview);
            this.Name = "ExportData";
            this.Size = new System.Drawing.Size(1223, 658);
            this.Load += new System.EventHandler(this.ExportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salseGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsGridview;
        private System.Windows.Forms.DataGridView salseGridview;
        private System.Windows.Forms.Button exportButton;
    }
}
