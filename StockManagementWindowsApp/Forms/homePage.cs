using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Controls;
using StockManagementWindowsApp.Forms;
using StockManagementWindowsApp.Gateway;

namespace StockManagementWindowsApp
{
    public partial class homePage : Form
    {

        public homePage()
        {
            InitializeComponent();
        }
        private void homePage_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(Introduce.instance);

        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit The Program?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;

            }

        }



        private void toolStripMenuItemHome_Click(object sender, EventArgs e)
        {

            CloseOpen(sender, e);
            panel.Controls.Clear();
            if (!panel.Controls.Contains(Introduce.instance))
            {
                panel.Controls.Add(Introduce.instance);
            }
            else
            {
                panel.Controls.Remove(Introduce.instance);
            }

        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(CatagorySetup.instance))
            {
                panel.Controls.Add(CatagorySetup.instance);
            }
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(CompanySetup.instance))
            {
                panel.Controls.Add(CompanySetup.instance);
            }
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(StockIn.instance))
            {
                panel.Controls.Add(StockIn.instance);
            }
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(ItemSetup.instance))
            {
                panel.Controls.Add(ItemSetup.instance);
            }
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(StockOut.instance))
            {
                panel.Controls.Add(StockOut.instance);
            }
        }

        private void reActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(Reactive.instance))
            {
                panel.Controls.Add(Reactive.instance);
            }
        }





        private void changePassordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(ChangePassword.instance))
            {
                panel.Controls.Add(ChangePassword.instance);
            }
        }
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(History.instance))
            {
                panel.Controls.Add(History.instance);
            }
        }

        public void load_form(Form frm)
        {

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.BringToFront();
            frm.Show();

        }

        public void CloseOpen(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }



        private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(ExportData.instance))
            {
                panel.Controls.Add(ExportData.instance);
            }
        }
        // Help Menu Item
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCBPmZof8rPoVEga-A8L8VDQ/playlists");
        }

        private void changeFileLocationToolStripUpload_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(Upload.instance))
            {
                panel.Controls.Add(Upload.instance);
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            if (!panel.Controls.Contains(About.Instance))
            {
                panel.Controls.Add(About.Instance);
            }
        }


        private void homePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                dynamic result = MessageBox.Show("Do You Want To Exit?", "Confirm To Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

    }
}
