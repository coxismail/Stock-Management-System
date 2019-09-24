using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Controls
{
    public partial class Introduce : UserControl
    {
        CMessageBox cMessageBox = new CMessageBox();
        OthersGateway othersGateway = new OthersGateway();
        SetupGateway setupGateway = new SetupGateway();
        public Regex Ch = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        public Regex CN = new Regex(@"^[a-zA-Z][ a-zA-Z.,-=]+(([a-zA-Z0-9 .,-=]))");
        public Regex MoNu = new Regex(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$");
        public Regex Adress = new Regex(@"[A-Za-z0-9'\.\-\s\,]");
        public Regex Email = new Regex(@"^[A-Za-z0-9+_.-]+@[a-zA-Z0-9.-]+$");
        public Regex Website = new Regex(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$");
        private static Introduce _instance;

        public static Introduce instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Introduce();
                return _instance;

            }
        }
        public Introduce()
        {
            InitializeComponent();
        }
        private void Introduce_Load(object sender, EventArgs e)
        {
            Tcat.Text = "";
            Tcom.Text = "";
            TIt.Text = "";
            TstoQ.Text = "";
            TSprice.Text = "";
            date.Text = "";
            CountLoad();
            logo();

            // Infor Update
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label333.Visible = false;
            label334.Visible = false;
            instituteBox.Visible = false;
            emailBox.Visible = false;
            addressBox.Visible = false;
            webBox.Visible = false;
            MobileNumberBox.Visible = false;
            nameBox.Visible = false;
            welcomeBox.Visible = false;
            upDateButton.Visible = false;


            // Information
            IntroduceModel introduction = othersGateway.GetInformation();
            if (introduction != null)
            {
                instituteNameLabel.Text = introduction.InstituteName;
                line3.Text = introduction.Address;
                line4.Text = introduction.OwnerName;
                line5.Text = "Cell :" + introduction.Mobile + ", Email:" + introduction.Email + " Web:" + introduction.WebSite;
                welLabel.Text = introduction.WelcomeNote;
            }









        }

        private void logo()
        {
            // logo showing code
            byte[] logo = othersGateway.loadLogo();
            if (logo != null)
            {
                MemoryStream memoryStream = new MemoryStream(logo);
                logoBox.Image = Image.FromStream(memoryStream);
            }
            else
            {
                logoBox.Image = null;
                logoBox.Visible = false;
            } 
        }
        public void CountLoad()
        {
            CountModel CountList = null;
              CountList  = setupGateway.CountAll();
            if (CountList != null)
            {
                Tcat.Text = CountList.TotaCatagory.ToString();
                Tcom.Text = CountList.TotalCompany.ToString();
                TIt.Text = CountList.TotalItems.ToString();
                TstoQ.Text = CountList.TotalStock.ToString();
                TSprice.Text = CountList.StockPrice.ToString();
            }
            date.Text ="Date : "+ DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Introduce_Load(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label333.Visible = true;
            label334.Visible = true;
            instituteBox.Visible = true;
            emailBox.Visible = true;
            addressBox.Visible = true;
            webBox.Visible = true;
            MobileNumberBox.Visible = true;
            nameBox.Visible = true;
            welcomeBox.Visible = true;
            upDateButton.Visible = true;
            IntroduceModel introduction = othersGateway.GetInformation();
            if (introduction != null)
            {
                instituteBox.Text = introduction.InstituteName;
                emailBox.Text = introduction.Email;
                addressBox.Text = introduction.Address;
                webBox.Text = introduction.WebSite;
                MobileNumberBox.Text = introduction.Mobile;
                nameBox.Text = introduction.OwnerName;
                welcomeBox.Text = introduction.WelcomeNote;
            }
        }

        private void upDateButton_Click(object sender, EventArgs e)
        {
            if (instituteBox.Text.Trim() == String.Empty|| emailBox.Text.Trim() == String.Empty || addressBox.Text.Trim()== String.Empty||webBox.Text.Trim()== String.Empty||MobileNumberBox.Text.Trim()==String.Empty || nameBox.Text.Trim()== String.Empty || welcomeBox.Text.Trim() == String.Empty)
            {
                cMessageBox.Warning("Please fillout all filds");
            }
            else
            {
                IntroduceModel introduce = new IntroduceModel();
                introduce.OwnerName = nameBox.Text.Trim();
                introduce.Address = addressBox.Text.Trim();
                introduce.Email = emailBox.Text.Trim();
                introduce.Mobile = MobileNumberBox.Text.Trim();
                introduce.InstituteName = instituteBox.Text.Trim();
                introduce.WebSite = webBox.Text.Trim();
                introduce.WelcomeNote = welcomeBox.Text.Trim();
               int rowAffect = othersGateway.SaveInformation(introduce);
               if (rowAffect >0)
                {
                   cMessageBox.Success("Information Updated");
                   Introduce_Load(sender,e);
                }
               else
               {
                   cMessageBox.Failed("Faild To Update New Record Try Again");
               }
            }

        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (!Ch.IsMatch(nameBox.Text.Trim()))
            {
                nameBox.Text = "Your Name";
            }
        }

        private void welcomeBox_Leave(object sender, EventArgs e)
        {
            if (!Ch.IsMatch(welcomeBox.Text.Trim()))
            {
                welcomeBox.Text = "Welcome!";
            }
        }

        private void instituteBox_Leave(object sender, EventArgs e)
        {
            if (!Ch.IsMatch(instituteBox.Text.Trim()))
            {
                instituteBox.Text = "Your Personal Institute!";
            }
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            if (!Adress.IsMatch(addressBox.Text.Trim()))
            {
                addressBox.Text = "Post, Thana, Zilla/City";
            }
        }

        private void MobileNumberBox_Leave(object sender, EventArgs e)
        {
            if (!MoNu.IsMatch(MobileNumberBox.Text.Trim()))
            {
                MobileNumberBox.Text = "018xxxxxxxx";
            }
        }

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (!Email.IsMatch(emailBox.Text))
            {
                emailBox.Text = " ";
            }
        }

        private void webBox_Leave(object sender, EventArgs e)
        {
            if (!Website.IsMatch(webBox.Text.Trim()))
            {
                webBox.Text = " ";
            }
        }


    }
}
