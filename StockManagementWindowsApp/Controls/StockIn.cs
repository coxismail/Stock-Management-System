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
    public partial class StockIn : UserControl
    {
        private static StockIn _instance;

        public static StockIn instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StockIn();
                return _instance;

            }
        }
        public Regex inte = new Regex(@"^\d+$");
        CMessageBox messageBox = new CMessageBox();
        public StockIn()
        {
            InitializeComponent();
         
        }

        public void LoadCatagoryAndCompany()
        {
            // Load Data To catagory and CompanyList
            SetupGateway setupGateway = new SetupGateway();
            List<CatagoryModel> catagorylist = setupGateway.GetAllCatagory();
            List<CompanyModel> companyList = setupGateway.GetAllCompany();

            if (catagorylist.Count > 0)
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
            if (companyList.Count > 0)
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
     
        private void StockIn_Load(object sender, EventArgs e)
        {
            LoadCatagoryAndCompany();
            // Used in Stock In Section
            ItemListBox.DataSource = null;
            priceTextBox.Text = "";
            availAbleQuatityTextBox.Text ="";
            stockInQuatityTextBox.Text = "";
            itemIdHidden.Text = "";
            totalPriceTextBox.Text = "";
        }
        private void companyListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListItem();
     
        }

        private void catagoryListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListItem();
        }
        private void ItemListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            itemIdHidden.Text = "";
            priceTextBox.Text = "";
            availAbleQuatityTextBox.Text = null;
            ItemGateway itemGateway = new ItemGateway();
            int id = Convert.ToInt32(ItemListBox.SelectedValue);
            if (ItemListBox.SelectedValue != null)
            {
                ItemsModel itemsModel = itemGateway.GetItemsByID(id);

                {
                    itemIdHidden.Text = itemsModel.Id.ToString();
                    priceTextBox.Text = itemsModel.Price.ToString();
                    availAbleQuatityTextBox.Text = itemsModel.StockAQ.ToString();
                    int quantity = Convert.ToInt32(availAbleQuatityTextBox.Text);
                    int price = Convert.ToInt32(priceTextBox.Text);
                    int totaprice = quantity * price;
                    totalPriceTextBox.Text = totaprice.ToString();
                }
            }
        }

        private void stockinButton_Click(object sender, EventArgs e)
        {


            if (!inte.IsMatch(stockInQuatityTextBox.Text.Trim())
                || catagoryListBox.SelectedValue == null ||
                companyListBox.SelectedValue == null ||
                ItemListBox.SelectedValue == null)
            {
                messageBox.Information("Please Make Sure That Your input is Correct!");
                
            }
            else
            {
                ItemGateway itemGateway = new ItemGateway();
                ItemsModel itemStockin = new ItemsModel();
                try
                {
                    itemStockin.Id = Convert.ToInt32(itemIdHidden.Text);
                    itemStockin.StockAQ = Convert.ToInt32(stockInQuatityTextBox.Text);
                    int rowAffect = itemGateway.StockIn(itemStockin);
                    if (rowAffect > 0)
                    {
                        messageBox.Success("Stock In Successfull");
                        StockIn_Load(sender, e);
                    }
                    else
                    {
                        messageBox.Failed("Faild to Stock In, Pleasy Try Again");
                        StockIn_Load(sender, e);
                    }
                }
                catch (Exception)
                {

                    messageBox.Failed("Something went wrong");
                }
           

            }
        }

        public void LoadListItem()
        {
            ItemListBox.Text = "";
            ItemListBox.SelectedValue = 0;
            ItemListBox.DataSource = null;
            itemIdHidden.Text = "";
            priceTextBox.Text = "";
            availAbleQuatityTextBox.Text = "";
            List<ItemsModel> itemslists = itemlistBoxData();
            if (itemslists.Count > 0)
            {
                var itemsList = itemslists.Select(x => new
                {
                    Value = x.Id,
                    Text = x.Name
                }).ToList();
                ItemListBox.ValueMember = "Value";
                ItemListBox.DisplayMember = "Text";
                ItemListBox.DataSource = itemsList;
                ItemListBox.SelectedValue = 0;
                ItemListBox.SelectedText = "--Select Item--";
            }
            else
            {
                ItemListBox.SelectedValue = 0;
                ItemListBox.SelectedText = "--No Items Found--";
            }
        }
        public List<ItemsModel> itemlistBoxData()
        {
            ItemGateway itemGateway = new ItemGateway();
            List<ItemsModel> itemslist = null;
            ItemListBox.Items.Clear();
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

        private void label3_Click(object sender, EventArgs e)
        {
            StockIn_Load(sender, e);
        }


    }
}
