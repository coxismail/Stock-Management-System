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

    public partial class CompanySetup : UserControl
    {
        public Regex Ch = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        CMessageBox cMessageBox = new CMessageBox();
        private static CompanySetup _instance;

        public static CompanySetup instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CompanySetup();
                return _instance;

            }
        }

        public CompanySetup()
        {
            InitializeComponent();
        }

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            companyTextBox.Text = "";
            companyIdHidden.Text = "";
            ListofCompany();
        }

        public void ListofCompany()
        {
            // Companay Section Code
            SetupGateway setupGateway = new SetupGateway();
            List<CompanyModel> companyList = setupGateway.GetAllCompany();
            if (companyList != null)
            {
                companyGridview.Rows.Clear();
                totalCompanyLabel.Text = "Total : " + companyList.Count + " Companies Found";
                companyGridview.ColumnCount = 3;
                companyGridview.Columns[0].Name = "SL";
                companyGridview.Columns[0].Width = 60;
                companyGridview.Columns[1].Name = "ID";
                companyGridview.Columns[1].Width = 60;
                companyGridview.Columns[2].Name = "Company Name";
                companyGridview.Columns[2].Width = 200;
             //   companyGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                int rn = 0;
                foreach (CompanyModel company in companyList)
                {
                    int inc = companyList.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    companyGridview.Rows.Add(rn, company.Id, company.Name);

                }

            }
        }

        private void companySaveButton_Click(object sender, EventArgs e)
        {
            // Regex Name = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
            if (!Ch.IsMatch(companyTextBox.Text.Trim()))
            {
                cMessageBox.Information("Something went wrong");
            }
            else
            {
                CompanyModel companyModel = new CompanyModel();
                companyModel.Name = companyTextBox.Text.Trim();
                SetupGateway companyGateway = new SetupGateway();
                bool isExist = companyGateway.IsExistCompany(companyModel);
                if (isExist)
                {
                    cMessageBox.Warning("Company Name Already Exist");
                }
                else
                {
                    int rowAffect = companyGateway.SaveCompany(companyModel);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Company Successfully Saved");
                        CompanySetup_Load(sender, e);


                    }
                    else
                    {
                        cMessageBox.Failed("Failed to Save, Please Try Again");
                        CompanySetup_Load(sender, e);
                    }
                }
            } // Expression check else function end here......
        }

        private void CompanyUpdateButton_Click(object sender, EventArgs e)
        {
            if (companyIdHidden.Text.Trim() != String.Empty && Ch.IsMatch(companyTextBox.Text.Trim()))
            {
                SetupGateway setupGateway = new SetupGateway();
                CompanyModel companyModel = new CompanyModel();
                companyModel.Name = companyTextBox.Text.Trim();
                companyModel.Id = Convert.ToInt32(companyIdHidden.Text.Trim());
                bool isExist = setupGateway.IsExistCompany(companyModel);
                if (isExist)
                {
                    cMessageBox.Warning("Company Name Already Exist");
                }
                else
                {
                    int rowAffect = setupGateway.UpdateCompany(companyModel);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Company Name Updated Successfully");
                        CompanySetup_Load(sender, e);
                    }
                    else
                    {
                        cMessageBox.Failed("Failed to Update");
                        CompanySetup_Load(sender, e);
                    } 
                }
                
            }
        }

        private void companyDeleteButton_Click(object sender, EventArgs e)
        {
            if (companyIdHidden.Text.Trim() != String.Empty && Ch.IsMatch(companyTextBox.Text.Trim()))
            {
                if (MessageBox.Show("Are sure to delete this?", "Confirm?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetupGateway setupGateway = new SetupGateway();
                    string Id = companyIdHidden.Text.Trim();
                    int rowAffect = setupGateway.DeleteCompany(Id);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Company Deleted");
                        CompanySetup_Load(sender, e);
                    }
                    else
                    {
                        cMessageBox.Failed("Failed to Delete");
                    }
                }
            }
        }
        private void companyGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || companyGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {
                companyGridview.CurrentRow.Selected = true;
                companyTextBox.Text = companyGridview.Rows[e.RowIndex].Cells["Company Name"].FormattedValue.ToString();
                companyIdHidden.Text = companyGridview.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CompanySetup_Load(sender, e);
        }
    }
}

