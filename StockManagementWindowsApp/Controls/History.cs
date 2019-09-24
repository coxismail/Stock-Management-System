using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;
using Excel = Microsoft.Office.Interop.Excel;


namespace StockManagementWindowsApp.Controls
{
    public partial class History : UserControl
    {
        private CMessageBox cMessageBox = new CMessageBox();
        SearchGateway serSearchGateway = new SearchGateway();
        public static History _instance;

        public static History instance
        {
            get
            {
                if (_instance == null)
                    _instance = new History();
                return _instance;

            }
        }
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // Hide Something
            startClander.Visible = false;
            endClander.Visible = false;
            exportButton.Visible = false;
            ItemListBox.DataSource = null;
            startDate.Text = "";
            endDate.Text = "";
            historyGridView.Rows.Clear();
            



            // Load Data To catagory and CompanyList
            SetupGateway setupGateway = new SetupGateway();
            List<CatagoryModel> catagorylist = setupGateway.GetAllCatagory();
            List<CompanyModel> companyList = setupGateway.GetAllCompany();

            if (catagorylist != null)
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
                catagoryListBox.SelectedText = "--No Categories Found--";
            }
            if (companyList != null)
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
                companyListBox.SelectedText = "--No Companies Found--";
            }

        }
        public void LoadListItem()
        {
            ItemListBox.Text = "";
            ItemListBox.SelectedValue = 0;
            ItemListBox.DataSource = null;
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

        private void catagoryListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListItem();
        }
        private void companyListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListItem();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            exportButton.Visible = false;
            historyGridView.Rows.Clear();
            if (startDate.Text != "" && endDate.Text != "")
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                if (startdate > enddate)
                {
                    cMessageBox.Warning("Start Date Must be Less then End Date");
                }
                else
                {
                    ShowCard();
                }
            }
            else
            {
                if (startDate.Text == "" && endDate.Text != "")
                {
                    cMessageBox.Information("Please Select Start Date");
                }
                if (startDate.Text != "" && endDate.Text == "")
                {
                    cMessageBox.Information("Please Select End Date");
                }
                else
                {
                    ShowCard();
                }
            }
        }


        public List<SearchViewModel> HistoryCardData()
        {
            List<SearchViewModel> SearchResult = null;
            if (startDate.Text == "" && endDate.Text == "" && Convert.ToInt32(catagoryListBox.SelectedValue) == 0 && Convert.ToInt32(companyListBox.SelectedValue) == 0)
            {
                SearchResult = serSearchGateway.SearchAll();
                return SearchResult;
            }
            if (startDate.Text != "" && endDate.Text != "" && Convert.ToInt32(catagoryListBox.SelectedValue) == 0 && Convert.ToInt32(companyListBox.SelectedValue) == 0)
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                SearchResult = serSearchGateway.SearchViewBytwoDate(startdate, enddate);
                return SearchResult;

            }
            if (startDate.Text != "" && endDate.Text != "" && Convert.ToInt32(catagoryListBox.SelectedValue) != 0 && Convert.ToInt32(companyListBox.SelectedValue) == 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                int cat = Convert.ToInt32(catagoryListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyDateWithCat(startdate, enddate, cat);
                return SearchResult;
            }
            if (startDate.Text != "" && endDate.Text != "" && Convert.ToInt32(catagoryListBox.SelectedValue) != 0 && Convert.ToInt32(companyListBox.SelectedValue) != 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                int cat = Convert.ToInt32(catagoryListBox.SelectedValue);
                int com = Convert.ToInt32(companyListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyDateWithCatCom(startdate, enddate, cat, com);
                return SearchResult;
            }
            if (startDate.Text != "" && endDate.Text != "" && Convert.ToInt32(catagoryListBox.SelectedValue) == 0 && Convert.ToInt32(companyListBox.SelectedValue) != 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                int com = Convert.ToInt32(companyListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyDateWithCom(startdate, enddate, com);
                return SearchResult;
            }
            if (startDate.Text != "" && endDate.Text != "" && Convert.ToInt32(ItemListBox.SelectedValue) != 0)
            {
                DateTime startdate = Convert.ToDateTime(startDate.Text);
                DateTime enddate = Convert.ToDateTime(endDate.Text);
                int item = Convert.ToInt32(ItemListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyDateWithItem(startdate, enddate, item);
                return SearchResult;
            }

            // without Date

            if (startDate.Text == "" && endDate.Text == "" && Convert.ToInt32(catagoryListBox.SelectedValue) != 0 && Convert.ToInt32(companyListBox.SelectedValue) == 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {

                int cat = Convert.ToInt32(catagoryListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyCatagory(cat);
                return SearchResult;
            }
            if (startDate.Text == "" && endDate.Text == "" && Convert.ToInt32(catagoryListBox.SelectedValue) != 0 && Convert.ToInt32(companyListBox.SelectedValue) != 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {
                int cat = Convert.ToInt32(catagoryListBox.SelectedValue);
                int com = Convert.ToInt32(companyListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyCatagoryandCompany(cat, com);
                return SearchResult;
            }
            if (startDate.Text == "" && endDate.Text == "" && Convert.ToInt32(catagoryListBox.SelectedValue) == 0 && Convert.ToInt32(companyListBox.SelectedValue) != 0 && Convert.ToInt32(ItemListBox.SelectedValue) == 0)
            {
                int com = Convert.ToInt32(companyListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyCompany(com);
                return SearchResult;
            }
            if (startDate.Text == "" && endDate.Text == "" && Convert.ToInt32(ItemListBox.SelectedValue) != 0)
            {
                int item = Convert.ToInt32(ItemListBox.SelectedValue);
                SearchResult = serSearchGateway.SearchbyItem(item);
                return SearchResult;
            }
            return SearchResult;
        }

        public void ShowCard()
        {
            if (HistoryCardData() != null)
            {
                exportButton.Visible = true;
                List<SearchViewModel> searchResults = HistoryCardData();

                historyGridView.ColumnCount = 6;
                historyGridView.Columns[0].Name = "SL";
                historyGridView.Columns[0].Width = 50;

                historyGridView.Columns[1].Name = "Category";
                historyGridView.Columns[1].Width = 130;
                historyGridView.Columns[2].Name = "Company";
                historyGridView.Columns[2].Width = 130;
                historyGridView.Columns[3].Name = "Item Name";
                historyGridView.Columns[3].Width = 120;
                historyGridView.Columns[4].Name = "Quantity";
                historyGridView.Columns[4].Width = 80;
                historyGridView.Columns[5].Name = "Price";
                historyGridView.Columns[5].Width = 120;
                //   historyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                int rn = 0;
                foreach (SearchViewModel results in searchResults)
                {
                    int inc = searchResults.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    historyGridView.Rows.Add(rn, results.CatagoryName, results.CompanyName, results.ItemName, results.Quantity, results.Price);

                }
                decimal price = searchResults.Sum(x => x.Price);
                int quantity = searchResults.Sum(x => x.Quantity);
                historyGridView.Rows.Add("", "..", "..", "TotaL", quantity, price);

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            History_Load(sender, e);
        }

        private void startDate_Click(object sender, EventArgs e)
        {
            endClander.Visible = false;
            startClander.Visible = true;
        }

        private void endDate_Click(object sender, EventArgs e)
        {
            startClander.Visible = false;
            endClander.Visible = true;
        }

        private void startClander_DateChanged(object sender, DateRangeEventArgs e)
        {
            startDate.Text = startClander.SelectionStart.ToShortDateString();

        }

        private void endClander_DateChanged(object sender, DateRangeEventArgs e)
        {
            endDate.Text = endClander.SelectionStart.ToShortDateString();

        }

        private void endClander_MouseLeave(object sender, EventArgs e)
        {
            endClander.Visible = false;
        }

        private void startClander_MouseLeave(object sender, EventArgs e)
        {
            startClander.Visible = false;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

            if (historyGridView.Rows.Count != 0)
            {
                Excel();
            }
            else
            {
                cMessageBox.Information("Please use filter search");
            }

        }

        public void Excel()
        {
            // creating Excel Application 
            Excel._Application app = new Excel.Application();
            // creating new WorkBook within Excel application 
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook 
            Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program 
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1. 
            // store its reference to worksheet 
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet 
            worksheet.Name = "Sales_History";
            // storing header part in Excel 
            for (int i = 1; i < historyGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = historyGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet 
            for (int i = 0; i < historyGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < historyGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = historyGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Sales_hisoty";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
           Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
           Type.Missing, Type.Missing);
            }

            // Exit from the application 
            app.Quit();
        }














        //    copyAlltoClipboard();
        //    Excel.Application xlexcel;
        //    Excel.Workbook xlWorkBook;
        //    Excel.Worksheet xlWorkSheet;
        //    object misValue = System.Reflection.Missing.Value;
        //    xlexcel = new Excel.Application();
        //    xlexcel.Visible = true;
        //    xlWorkBook = xlexcel.Workbooks.Add(misValue);
        //    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        //    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
        //    CR.Select();
        //    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        //}

        //private void copyAlltoClipboard()
        //{
        //    historyGridView.SelectAll();
        //    DataObject dataObj = historyGridView.GetClipboardContent();
        //    if (dataObj != null)
        //    Clipboard.SetDataObject(dataObj);
        //}


    }
}
