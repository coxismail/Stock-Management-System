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
    public partial class ItemSetup : UserControl
    {
        private Regex CN = new Regex(@"^[a-zA-Z][ a-zA-Z.,-=]+(([a-zA-Z0-9 .,-=]))");
        private Regex Nu = new Regex(@"^\d+(,\d{3})*(\.\d{1,2})?$");
        CMessageBox cMessageBox = new CMessageBox();
        private static ItemSetup _instance;

        public static ItemSetup instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ItemSetup();
                return _instance;

            }
        }
        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            itemsGridView.Rows.Clear();
            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
            itemsIdHidden.Text = "";
            // Load Data To catagory and CompanyList
            SetupGateway setupGateway = new SetupGateway();
            List<CatagoryModel> catagorylist = setupGateway.GetAllCatagory();
            List<CompanyModel> companyList = setupGateway.GetAllCompany();

            if (catagorylist.Count>0)
            {
                var catagoryList = catagorylist.Select(x => new
                {
                    Value = x.Id,
                    Text = x.Name
                }).ToList();
                catagoryListBox.ValueMember = "Value";
                catagoryListBox.DisplayMember = "Text";
                catagoryListBox.DataSource = catagoryList;
                catagoryListBox.SelectedValue = 0;
                catagoryListBox.SelectedText = "--Select Category--";
            }
            else
            {
                catagoryListBox.SelectedValue = 0;
                catagoryListBox.Text = "";
                catagoryListBox.SelectedText = "--No Category--";
            }
            if (companyList.Count>0)
            {
                var companylist = companyList.Select(x => new
                {
                    Value = x.Id,
                    Text = x.Name
                }).ToList();
                companyListBox.ValueMember = "Value";
                companyListBox.DisplayMember = "Text";
                companyListBox.DataSource = companylist;
                companyListBox.SelectedValue = 0;
                companyListBox.SelectedText = "--Select Company--";
            }
            else
            {
                companyListBox.SelectedValue = 0;
                companyListBox.Text = "";
                companyListBox.SelectedText = "--No Company--";
            }
        }
        // Items Section Code
        private void itemSaveButton_Click(object sender, EventArgs e)
        {
            if (!CN.IsMatch(itemNameTextBox.Text.Trim()) || !Nu.IsMatch(itemPriceTextBox.Text.Trim())
                || catagoryListBox.SelectedValue == null || companyListBox.SelectedValue == null)
            {
                cMessageBox.Warning("Please Make Sure That Your All Input is Correct");
            }
            else
            {
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.CatagoryID = Convert.ToInt32(catagoryListBox.SelectedValue);
                itemsModel.CompanyID = Convert.ToInt32(companyListBox.SelectedValue);
                itemsModel.Name = itemNameTextBox.Text.Trim();
                itemsModel.Price = Convert.ToInt32(itemPriceTextBox.Text.Trim());
                SetupGateway itemGateway = new SetupGateway();
                bool isItemExist = itemGateway.IsItemExists(itemsModel);
                if (isItemExist == true)
                {
                    cMessageBox.Information("Item Already Exist");
                }
                else
                {
                    int rowAffect = itemGateway.SaveItem(itemsModel);
                    if (rowAffect > 0)
                    {
                        cMessageBox.Success("Item Successfully Saved");
                        ItemSetup_Load(sender, e);
                    }
                    else
                    {
                        cMessageBox.Failed("Faild to Save, Please Try Again");
                    }
                }


            }

        }
        private void itemUpdateButton_Click(object sender, EventArgs e)
        {
            if (CN.IsMatch(itemNameTextBox.Text.Trim()) || Nu.IsMatch(itemPriceTextBox.Text.Trim()))
            {

                ItemGateway itemGateway = new ItemGateway();
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.Name = itemNameTextBox.Text.Trim();
                itemsModel.Price = Convert.ToDecimal(itemPriceTextBox.Text.Trim());
                itemsModel.Id = Convert.ToInt32(itemsIdHidden.Text.Trim());
                int rowAffect = itemGateway.UpdateItem(itemsModel);
                if (rowAffect > 0)
                {
                    cMessageBox.Success("Items Name and Price Updated");
                    ItemSetup_Load(sender, e);
                }
                else
                {
                    cMessageBox.Failed("Failed to Update");
                }
            }
        }

        private void itemDeleteButton_Click(object sender, EventArgs e)
        {
            if (!CN.IsMatch(itemNameTextBox.Text.Trim()) || !Nu.IsMatch(itemPriceTextBox.Text.Trim()))
            {
                cMessageBox.Information("Please Select al Least One Item Two Delete");
            }
            else
            {
                if (cMessageBox.Quiestion("Are sure to delete this?"))
                {
                    string id = itemsIdHidden.Text.Trim();
                    ItemGateway itemGateway = new ItemGateway();
                    itemGateway.DeleteItem(id);
                    ItemSetup_Load(sender, e);
                }
            }
        }
        private void catagoryListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowList("Category");
        }

        private void companyListBox_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            ShowList("Company");
        }


        public void ShowList(string es)
        {
            itemsGridView.Rows.Clear();
            itemNameTextBox.Text = "";
            itemPriceTextBox.Text = "";
            itemsIdHidden.Text = "";
            List<ItemsModel> itemlist = itemlistBoxData();
            if (itemlist != null)
            {
                totalItemsLabel.Text = "TotaL : " + itemlist.Count + " Items For This " + es;
                itemsGridView.ColumnCount = 5;
                itemsGridView.Columns[0].Name = "SL";
                itemsGridView.Columns[0].Width = 60;
                itemsGridView.Columns[1].Name = "ID";
                itemsGridView.Columns[1].Width = 60;
                itemsGridView.Columns[2].Name = "Items Name";
                itemsGridView.Columns[2].Width = 180;
                itemsGridView.Columns[3].Name = "Price";
                itemsGridView.Columns[3].Width = 100;
                itemsGridView.Columns[4].Name = "Av. Quantity";
                itemsGridView.Columns[4].Width = 100;

            //    itemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                int rn = 0;
                foreach (ItemsModel items in itemlist)
                {
                    int inc = itemlist.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    itemsGridView.Rows.Add(rn, items.Id, items.Name, items.Price, items.StockAQ);
                }
            }
        }
        public List<ItemsModel> itemlistBoxData()
        {
            ItemGateway itemGateway = new ItemGateway();
            List<ItemsModel> itemslist = null;
            if (companyListBox.SelectedValue == null && catagoryListBox.SelectedValue != null)
            {
                int id = Convert.ToInt32(catagoryListBox.SelectedValue);
                itemslist = itemGateway.GetItemsByCatagoryID(id);
                return itemslist;
            }
            if (companyListBox.SelectedValue != null && catagoryListBox.SelectedValue != null)
            {
                int catagoryid = Convert.ToInt32(catagoryListBox.SelectedValue);
                int companyid = Convert.ToInt32(companyListBox.SelectedValue);
                itemslist = itemGateway.GetItemsByCompanyandCatagoryID(catagoryid, companyid);
                return itemslist;
            }
            if (catagoryListBox.SelectedValue == null && companyListBox.SelectedValue != null)
            {
                int companyid = Convert.ToInt32(companyListBox.SelectedValue);
                itemslist = itemGateway.GetItemsByCompanyID(companyid);
                return itemslist;
            }

            return itemslist;
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || itemsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {
                itemsGridView.CurrentRow.Selected = true;
                itemNameTextBox.Text = itemsGridView.Rows[e.RowIndex].Cells["Items Name"].FormattedValue.ToString();
                itemPriceTextBox.Text = itemsGridView.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                itemsIdHidden.Text = itemsGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ItemSetup_Load(sender, e);
        }




    }
}
