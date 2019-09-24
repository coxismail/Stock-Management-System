using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using StockManagementWindowsApp.Controls;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Forms
{
    public partial class OutDated : Form
    {
        public Regex Email = new Regex(@"^[A-Za-z0-9+_.-]+@[a-zA-Z0-9.-]+$");
        UserGateway userGateway = new UserGateway();
        CMessageBox cMessageBox = new CMessageBox();
        public OutDated()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OutDated_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
            codeTextBox.Visible = false;
            emailTextBox.Visible = false;
            activeButton.Visible = false;
            getCodeButton.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userGateway.isAlreadySent())
                {
                    label8.Visible = true;
                    codeTextBox.Visible = true;
                    activeButton.Visible = true;
                }
                else
                {
                    label9.Visible = true;
                    emailTextBox.Visible = true;
                    getCodeButton.Visible = true;
                }
            }
            catch (Exception)
            {

                cMessageBox.Failed("Something went wrong, try Again");
            }
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text.Trim() != "")
            {
                RegisterModel register = new RegisterModel();
                register.ActivationCode = codeTextBox.Text.Trim();
                register.ActivationDate = DateTime.Today;
                if (userGateway.isAlreadySent())
                {
                    int rowAffect = userGateway.Active(register);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Updated Successfully, Please Restart The Program");
                        Application.Exit();
                    }
                    else
                    {
                        cMessageBox.Failed("Invaild Code, or Its out of Dated");
                    }
                }
                else
                {
                    cMessageBox.Warning("Faild to active");
                }


            }

        }

        private void getCodeButton_Click(object sender, EventArgs e)
        {
            if (!Email.IsMatch(emailTextBox.Text.Trim()))
            {
                cMessageBox.Information("Your Email is not Correct");
            }
            else
            {
                string ma = emailTextBox.Text;
                string mas = ma.Substring(0, 5);
                string scode = "SA-" + DateTime.Now.ToString("MM-dd") + "-";
                for (int i = 0; i <= mas.Length; i++)
                {
                    scode += scode + mas.Substring(0, 3) + i;
                }
                char[] charArray = scode.ToCharArray();
                Array.Reverse(charArray);
                string codes = new string(charArray);
                string newCode = codes.Substring(28, 62);
                bool connection = NetworkInterface.GetIsNetworkAvailable();
                if (connection == true)
                {
                   
                    try
                    {
                        string doc = "No Data is Set";
                        OthersGateway othersGateway = new OthersGateway();
                        IntroduceModel introduction = othersGateway.GetInformation();
                        if (introduction != null)
                        {
                            string ins = introduction.InstituteName;
                            string email = introduction.Email;
                            string add = introduction.Address;

                            string mob = introduction.Mobile;
                            string owner = introduction.OwnerName;
                            doc = "Document for : " + ins + ", \nEmail:" + email + ",\n Address :" + add + ",\n Mobile :" + mob + ",\nOwner :" + owner;
                        }
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("doeasily.coart@gmail.com");
                        mail.To.Add("coxismail.bd@gmail.com");
                        mail.Subject = "Activation For : " + emailTextBox.Text;
                        mail.Body = doc + "\nCode: " + newCode;
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("doeasily.coart@gmail.com", "@gmail.doeasily.coart");
                        SmtpServer.EnableSsl = true;
                        int rowAffect = userGateway.InsertCode(newCode);
                        if (rowAffect > 0)
                        {
                            SmtpServer.Send(mail);
                            cMessageBox.Success("Your Code has been Generated, You will get an Email in short Time.");
                        }
                        else
                        {
                            cMessageBox.Failed("Faild, Try Again or Contact with Developer");
                        }



                    }
                    catch (Exception)
                    {

                        cMessageBox.Failed("Failed to Generate Code");
                    }

                }
                else
                {
                    cMessageBox.Warning("No Internet Connection");
                }
            }

        }
    }
}
