namespace StockManagementWindowsApp.Controls
{
    partial class Upload
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
            this.urlTexBox = new System.Windows.Forms.TextBox();
            this.browsButton = new System.Windows.Forms.Button();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTexBox
            // 
            this.urlTexBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTexBox.Location = new System.Drawing.Point(53, 508);
            this.urlTexBox.Name = "urlTexBox";
            this.urlTexBox.ReadOnly = true;
            this.urlTexBox.Size = new System.Drawing.Size(378, 30);
            this.urlTexBox.TabIndex = 0;
            // 
            // browsButton
            // 
            this.browsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsButton.Location = new System.Drawing.Point(448, 504);
            this.browsButton.Name = "browsButton";
            this.browsButton.Size = new System.Drawing.Size(151, 36);
            this.browsButton.TabIndex = 1;
            this.browsButton.Text = "Browse";
            this.browsButton.UseVisualStyleBackColor = false;
            this.browsButton.Click += new System.EventHandler(this.browsButton_Click);
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(53, 36);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(546, 443);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewBox.TabIndex = 2;
            this.previewBox.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uploadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(53, 550);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(546, 36);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.browsButton);
            this.Controls.Add(this.urlTexBox);
            this.Name = "Upload";
            this.Size = new System.Drawing.Size(661, 619);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTexBox;
        private System.Windows.Forms.Button browsButton;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button uploadButton;
    }
}
