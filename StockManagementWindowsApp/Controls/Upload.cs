using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Gateway;

namespace StockManagementWindowsApp.Controls
{
    public partial class Upload : UserControl
    {
        CMessageBox cMessageBox = new CMessageBox();
        public static Upload _instance;

        public static Upload instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Upload();
                return _instance;

            }
        }
        public Upload()
        {
            InitializeComponent();
        }

        private void browsButton_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter ="Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg";
            openFileDialog.Title = "Select Image as Logo";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string url = openFileDialog.FileName;
                urlTexBox.Text = url;
                previewBox.Image = Image.FromFile(url);
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (urlTexBox.Text != String.Empty)
            {
                OthersGateway othersGateway = new OthersGateway();
                try
                {
                    string image = urlTexBox.Text;
                    FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                    byte[] bimage = new byte[fs.Length];
                    fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                   int rowAffect = othersGateway.uploadLogo(bimage);
                    if (rowAffect>0)
                    {
                      cMessageBox.Success("Logo Uploaded Successfully");
                    }
                    else
                    {
                        cMessageBox.Failed("Faild To upload");
                    }
                }
                catch (Exception)
                {
                    cMessageBox.Failed("Select a Vaild Image and Try again");
                }
            }
            
        }
    }
}
