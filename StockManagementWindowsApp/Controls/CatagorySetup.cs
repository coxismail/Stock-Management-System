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
    public partial class CatagorySetup : UserControl
    {
        CMessageBox cMessageBox = new CMessageBox();
        private static CatagorySetup _instance;

        public static CatagorySetup instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CatagorySetup();
                    return _instance;
                
            }
        }

        public Regex Ch = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        public CatagorySetup()
        {
            InitializeComponent();

        }

        public void CatagoriesList()
        {
            catagoryGridview.Rows.Clear();

            SetupGateway setupGateway = new SetupGateway();
            List<CatagoryModel> catagorylist = setupGateway.GetAllCatagory();

            if (catagorylist != null)
            {
                totalCatagoryLabel.Text = "TotaL : " + catagorylist.Count + " Categories Found";
                catagoryGridview.ColumnCount = 3;
                catagoryGridview.Columns[0].Name = "SL";
                catagoryGridview.Columns[0].Width = 60;
                catagoryGridview.Columns[1].Name = "ID";
                catagoryGridview.Columns[1].Width = 60;
                catagoryGridview.Columns[2].Name = "Category Name";
                catagoryGridview.Columns[2].Width = 200;
              //  catagoryGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                int rn = 0;
                foreach (CatagoryModel catagory in catagorylist)
                {
                    int inc = catagorylist.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    catagoryGridview.Rows.Add(rn, catagory.Id, catagory.Name);
                }
            }
        }
        private void CatagorySetup_Load(object sender, EventArgs e)
        {
            CatagoriesList();
            catagoryTextBox.Text = "";
            idhiddenLabel.Text = String.Empty;
        }
        private void catagorySaveButton_Click(object sender, EventArgs e)
        {

            if (!Ch.IsMatch(catagoryTextBox.Text.Trim()))
            {
                cMessageBox.Warning("Invaild Input Detected");
            }
            else
            {
                CatagoryModel catagoryModel = new CatagoryModel();
                catagoryModel.Name = catagoryTextBox.Text.Trim();
                SetupGateway catagoryGateway = new SetupGateway();
                bool isExist = catagoryGateway.IsExists(catagoryModel);
                if (isExist == true)
                {
                    cMessageBox.Information("Category Already Exist");
                }
                else
                {
                    int rowAffect = catagoryGateway.SaveCatagory(catagoryModel);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Category Successfully Saved");
                        CatagorySetup_Load(sender, e);


                    }
                    else
                    {
                        cMessageBox.Failed("Failed To Save Category, Try Again");
                        CatagorySetup_Load(sender, e);
                    }

                }
            }

        }

        private void CatagoryUpdateButton_Click(object sender, EventArgs e)
        {
            SetupGateway setupGateway = new SetupGateway();
            if (idhiddenLabel.Text.Trim() != String.Empty && Ch.IsMatch(catagoryTextBox.Text.Trim()))
            {
                CatagoryModel catagory = new CatagoryModel();
                catagory.Name = catagoryTextBox.Text.Trim();
                catagory.Id = Convert.ToInt32(idhiddenLabel.Text);
                bool isExist = setupGateway.IsExists(catagory);
                if (isExist == true)
                {
                    cMessageBox.Information("Category Already Exist");
                }
                else
                {
                    int rowAffect = setupGateway.UpdateCatagory(catagory);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Category Updated");
                        CatagorySetup_Load(sender, e);
                    }
                    else
                    {
                        cMessageBox.Failed("Faild to Updated Category");
                        CatagorySetup_Load(sender, e);
                    }
                }
           
            }
        }

        private void catagoryDeleteButton_Click(object sender, EventArgs e)
        {
            SetupGateway setupGateway = new SetupGateway();
            if (idhiddenLabel.Text.Trim() != String.Empty && catagoryTextBox.Text.Trim() != String.Empty)
            {
                if (cMessageBox.Quiestion("Are you sure to delete this?"))
                {
                    string id = idhiddenLabel.Text.Trim();
                    int rowAffect = setupGateway.DeleteCatagory(id);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Category Deleted");
                        CatagorySetup_Load(sender, e);
           
                    }
                    else
                    {
                        cMessageBox.Failed("Failed To Delete Category");
                        CatagorySetup_Load(sender, e);
                    }
                }


            }
        }
        private void catagoryGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || catagoryGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {
                catagoryGridview.CurrentRow.Selected = true;
                catagoryTextBox.Text = catagoryGridview.Rows[e.RowIndex].Cells["Category Name"].FormattedValue.ToString().Trim();
                idhiddenLabel.Text = catagoryGridview.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString().Trim();

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            CatagorySetup_Load(sender, e);
        }

       
    }
}
