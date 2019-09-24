using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Controls
{
    public partial class ChangePassword : UserControl
    {
        CMessageBox cMessageBox = new CMessageBox();
        public Regex Un = new Regex(@"^[A-Za-z0-9]+(?:[_-][A-Za-z0-9]+)*$");
        public Regex pw = new Regex(@"^[A-Za-z0-9.@#%]");
        private static ChangePassword _instance;
        public static ChangePassword instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChangePassword();
                return _instance;

            }
        }
        public ChangePassword()
        {
            InitializeComponent();
            password.PasswordChar = '\u25CF';
            newPassword.PasswordChar = '\u25CF';
            confirmPassword.PasswordChar = '\u25CF';
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            userName.Text = "";
            password.Text = "";
            newUserName.Text = "";
            newPassword.Text = "";
            confirmPassword.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userName.Text == "" || password.Text == "" || newUserName.Text == "" || newPassword.Text == "" || confirmPassword.Text == "" || newPassword.Text != confirmPassword.Text)
                {
                    cMessageBox.Warning("Please Fillout all fields and Make Sure That New and Confirm Password both are same");
               
                }
                else
                {
                    if (!Un.IsMatch(newUserName.Text.Trim()))
                    {
                        cMessageBox.Information("Your UserName is not in Correct Format");
                    }
                    if (!pw.IsMatch(newPassword.Text.Trim()))
                    {
                        cMessageBox.Information("Your Password is not in Correct Format");
                    }
                    else
                    {
                        UserGateway userGateway = new UserGateway();
                        User user = new User();
                        user.UserName = userName.Text.Trim();
                        user.Password = password.Text.Trim();
                        bool isVaild = userGateway.isVaildUser(user);
                        if (isVaild)
                        {
                            user.NewUserName = newUserName.Text.Trim();
                            user.NewPassword = newPassword.Text.Trim();
                            userGateway.ChangePassword(user);
                            cMessageBox.Success("Seccessfully Updated Password and UserName");
                            Application.Exit();
                            
                        }


                        else
                        {
                            cMessageBox.Failed("Your Current UserName or Password is not Correct");
                        }
                    }
                }
            }
            catch (Exception)
            {
                cMessageBox.Failed("Try Again");
            }
        }
    }
}
