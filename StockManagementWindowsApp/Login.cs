using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp
{
    public partial class loginForm : Form 
    {
  public loginForm()
        {
         
            InitializeComponent();
      password.PasswordChar = '\u25CF';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = userName.Text;
            user.Password = password.Text;
            UserGateway login = new UserGateway();
            bool isVaild = login.isVaildUser(user);
            if (isVaild == true)
            {
                
                this.Hide();
                homePage home = new homePage();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please Make Sure That Your Input is Correct.");
            }
           
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            login.Dispose();
            Close();
        }

        private void devlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/coxismail.bd"); 
        }
    }
}
