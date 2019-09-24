using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementWindowsApp.Controls
{
    class CMessageBox
    {
        public void Success(String Message)
        {
            System.Windows.Forms.MessageBox.Show(Message + "!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void Failed(String Message)
        {
            System.Windows.Forms.MessageBox.Show(Message + "", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Warning(String Message)
        {
            System.Windows.Forms.MessageBox.Show(Message + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Stop(String Message)
        {
            System.Windows.Forms.MessageBox.Show(Message + "", "Don't This", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        public bool Quiestion(String Message)
        {
            bool result = System.Windows.Forms.MessageBox.Show(Message + "", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (!result)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Information(String Message)
        {
            System.Windows.Forms.MessageBox.Show(Message + "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
