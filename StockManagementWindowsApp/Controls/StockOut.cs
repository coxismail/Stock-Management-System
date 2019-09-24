using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Org.BouncyCastle.Utilities.Zlib;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;
using Font = System.Drawing.Font;
using Image = iTextSharp.text.Image;
using Point = iTextSharp.awt.geom.Point;
using Rectangle = iTextSharp.text.Rectangle;

namespace StockManagementWindowsApp.Controls
{
    public partial class StockOut : UserControl
    {
        private CMessageBox cMessageBox = new CMessageBox();
        OthersGateway introduce = new OthersGateway();
        public Regex dnum = new Regex(@"^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$");
        public Regex inte = new Regex(@"^\d+$");
        public Regex fnum = new Regex(@"^[1-9]+[.0-9]*$");
        public Regex Ch = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        public Regex CN = new Regex(@"^[a-zA-Z0-9][ a-zA-Z0-9.,/-=]+(([a-zA-Z0-9 .,/-=]))");
        public Regex Nu = new Regex(@"^\d+(,\d{3})*(\.\d{1,2})?$");
        public Regex MoNu = new Regex(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$");
        public static StockOut _instance;

        public static StockOut instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StockOut();
                return _instance;

            }
        }

        public StockOut()
        {
            InitializeComponent();
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            listofStockOut.Clear();
            stockOutCard.Rows.Clear();

            // Text Box
            catagoryListBox.Enabled = true;
            companyListBox.Enabled = true;
            ItemListBox.DataSource = null;
            ItemListBox.Enabled = true;
            discountPercentTextBox.Enabled = true;
            discountPriceTexBox.Enabled = true;
            vatPercentTextBox.Enabled = true;
            outQuantityTextBox.Enabled = true;
            stockOutCard.Enabled = true;
            modelBox.Enabled = true;
            modelBox.Text = "N/A";
            priceTextBox.Text = "";
            outTotalPriceTextBox.Text = "";
            availAbleQuatityTextBox.Text = "";
            outQuantityTextBox.Text = "";
            discountPercentTextBox.Text = "";
            discountPriceTexBox.Text = "";
            vatPercentTextBox.Text = "";
            vatPriceTextBox.Text = "";
            netBillTexBox.Text = "";
            cardTitle.Text = "";


            // Customer name and label fileds
            mnumberBox.Visible = false;
            customerNameBox.Visible = false;
            addressTextBox.Visible = false;
            nameLabel.Visible = false;
            addLabel.Visible = false;
            numberLabel.Visible = false;
            // Button for actioins
            saleButton.Enabled = true;
            saleButton.Visible = false;
            lostButton.Visible = false;
            damageButton.Visible = false;
            okButton.Visible = false;
            cancelButton.Visible = false;
            addCardButton.Enabled = true;




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
                catagoryListBox.SelectedText = "--No Category Found--";
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
                companyListBox.SelectedText = "--No Company Found--";
            }
        }

        private void companyListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListItem();
        }

        private void catagoryListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            LoadListItem();
        }

        public void LoadListItem()
        {
            ItemListBox.Text = "";
            ItemListBox.SelectedValue = 0;
            ItemListBox.DataSource = null;
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

        private void ItemListBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ItemGateway itemGateway = new ItemGateway();
            int id = Convert.ToInt32(ItemListBox.SelectedValue);
            if (ItemListBox.SelectedValue != null)
            {
                ItemsModel itemsModel = itemGateway.GetItemsByID(id);

                {
                    outItemIdHidden.Text = itemsModel.Id.ToString();
                    priceTextBox.Text = itemsModel.Price.ToString();
                    availAbleQuatityTextBox.Text = itemsModel.StockAQ.ToString();


                    // Create Empty Value
                    outQuantityTextBox.Text = String.Empty;
                    discountPercentTextBox.Text = String.Empty;
                    discountPriceTexBox.Text = String.Empty;
                    netBillTexBox.Text = String.Empty;
                    vatPercentTextBox.Text = String.Empty;
                    vatPriceTextBox.Text = String.Empty;

                }
            }
        }

        private void outQuantityTextBox_Leave(object sender, EventArgs e)
        {
            if (!inte.IsMatch(outQuantityTextBox.Text.Trim()))
            {
                outQuantityTextBox.Text = "";
                outTotalPriceTextBox.Text = "";
                netBillTexBox.Text = "";
            }
            else
            {
                try
                {
                    if (availAbleQuatityTextBox.Text.Trim() != String.Empty &&
                     outQuantityTextBox.Text.Trim() != String.Empty)
                    {
                        int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                        int price = Convert.ToInt32(priceTextBox.Text);
                        int totaprice = quantity * price;
                        outTotalPriceTextBox.Text = totaprice.ToString();
                    }
                    vatPriceTextBox.Text = Vat().ToString();
                    netBillTexBox.Text = NetBill().ToString();
                }
                catch (Exception)
                {

                    outQuantityTextBox.Text = "0";
                }

            }

        }

        private void discountPercentTextBox_Leave(object sender, EventArgs e)
        {

            if (!fnum.IsMatch(discountPercentTextBox.Text.Trim()) || !inte.IsMatch(outQuantityTextBox.Text.Trim()))
            {
                discountPercentTextBox.Text = "";
            }
            else
            {
                try
                {
                    if (discountPercentTextBox.Text.Trim() != String.Empty && outQuantityTextBox.Text.Trim() != String.Empty)
                    {
                        int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                        int price = Convert.ToInt32(priceTextBox.Text);
                        int totalprice = quantity * price;
                        Decimal discountPercent = Convert.ToDecimal(discountPercentTextBox.Text.Trim());
                        Decimal discount = discountPercent / 100 * totalprice;
                        string result = discount.ToString();
                        if (result.Contains("."))
                        {
                            int dotIndex = result.IndexOf(".");
                            discountPriceTexBox.Text = result.Substring(0, dotIndex + 2);
                        }
                        else
                        {
                            discountPriceTexBox.Text = result;
                        }

                        //"C", CultureInfo.CreateSpecificCulture("bn-BD"
                    }
                    vatPriceTextBox.Text = Vat().ToString();
                    netBillTexBox.Text = NetBill().ToString();
                }
                catch (Exception)
                {

                    discountPercentTextBox.Text = "0";
                }

            }



        }



        private void discountPriceTexBox_Leave(object sender, EventArgs e)
        {

            if (!fnum.IsMatch(discountPriceTexBox.Text.Trim()) || !inte.IsMatch(outQuantityTextBox.Text.Trim()))
            {
                discountPriceTexBox.Text = "";
            }
            else
            {
                try
                {
                    if (discountPriceTexBox.Text.Trim() != String.Empty && outQuantityTextBox.Text.Trim() != String.Empty)
                    {
                        int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                        int price = Convert.ToInt32(priceTextBox.Text);
                        int totalprice = quantity * price;
                        Decimal discountAmount = Convert.ToDecimal(discountPriceTexBox.Text.Trim());
                        Decimal discountPercent = discountAmount / totalprice * 100;
                        string result = discountPercent.ToString();
                        if (result.Contains("."))
                        {
                            int dotIndex = result.IndexOf(".");
                            discountPercentTextBox.Text = result.Substring(0, dotIndex + 2);
                        }
                        else
                        {
                            discountPercentTextBox.Text = result;
                        }
                    }
                    vatPriceTextBox.Text = Vat().ToString();
                    netBillTexBox.Text = NetBill().ToString();
                }
                catch (Exception)
                {

                    discountPriceTexBox.Text = "0";
                }


            }


        }

        private void vatPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!fnum.IsMatch(vatPercentTextBox.Text.Trim()))
            {
                vatPercentTextBox.Text = "";
            }
            else
            {
                vatPriceTextBox.Text = Vat().ToString();
                netBillTexBox.Text = NetBill().ToString();
            }

        }





        public Decimal Vat()
        {
            try
            {
                if (vatPercentTextBox.Text.Trim() != "" &&
                               outQuantityTextBox.Text.Trim() != "" &&
                               discountPriceTexBox.Text.Trim() != "")
                {
                    int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                    int price = Convert.ToInt32(priceTextBox.Text);
                    decimal discunt = Convert.ToDecimal((discountPriceTexBox.Text.Trim()));
                    decimal vatPercent = Convert.ToDecimal(vatPercentTextBox.Text.Trim());
                    decimal totalAmount = quantity * price - discunt;
                    decimal vat = vatPercent / 100 * totalAmount;
                    return vat;

                }
                if (vatPercentTextBox.Text.Trim() != "" &&
                    outQuantityTextBox.Text.Trim() != "" &&
                    discountPriceTexBox.Text.Trim() == "")
                {
                    int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                    int price = Convert.ToInt32(priceTextBox.Text);
                    decimal vatPercent = Convert.ToDecimal(vatPercentTextBox.Text.Trim());
                    decimal totalAmount = quantity * price;
                    decimal vat = vatPercent / 100 * totalAmount;
                    return vat;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }

        }


        public Decimal NetBill()
        {

            if (outQuantityTextBox.Text.Trim() != String.Empty && discountPriceTexBox.Text.Trim() == String.Empty &&
                vatPriceTextBox.Text.Trim() == String.Empty)
            {
                int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                int price = Convert.ToInt32(priceTextBox.Text);
                Decimal netbill = quantity * price;
                return netbill;
            }
            if (outQuantityTextBox.Text.Trim() != String.Empty && discountPriceTexBox.Text.Trim() != String.Empty &&
                vatPriceTextBox.Text.Trim() == String.Empty)
            {
                int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                int price = Convert.ToInt32(priceTextBox.Text);
                Decimal discount = Convert.ToDecimal(discountPriceTexBox.Text.Trim());
                Decimal netbill = quantity * price - discount;
                return netbill;
            }
            if (outQuantityTextBox.Text.Trim() != String.Empty && discountPriceTexBox.Text.Trim() != String.Empty &&
                vatPriceTextBox.Text.Trim() != String.Empty)
            {
                int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                int price = Convert.ToInt32(priceTextBox.Text);
                Decimal discount = Convert.ToDecimal(discountPriceTexBox.Text.Trim());
                Decimal vat = Convert.ToDecimal(vatPriceTextBox.Text.Trim());
                Decimal netbill = quantity * price - discount + vat;
                return netbill;
            }
            if (outQuantityTextBox.Text.Trim() != String.Empty && discountPriceTexBox.Text.Trim() == String.Empty &&
                vatPriceTextBox.Text.Trim() != String.Empty)
            {
                int quantity = Convert.ToInt32(outQuantityTextBox.Text);
                int price = Convert.ToInt32(priceTextBox.Text);
                Decimal vat = Convert.ToDecimal(vatPriceTextBox.Text.Trim());
                Decimal netbill = quantity * price + vat;
                return netbill;
            }
            return 0;
        }



        private List<StockOutModel> listofStockOut = new List<StockOutModel>();

        private void addCardButton_Click(object sender, EventArgs e)
        {
            if (outQuantityTextBox.Text.Trim() != String.Empty && netBillTexBox.Text.Trim() != String.Empty)
            {
                if (inte.IsMatch(outQuantityTextBox.Text.Trim()))
                {
                    int outQ = Convert.ToInt32(outQuantityTextBox.Text.Trim());
                    int avQ = Convert.ToInt32(availAbleQuatityTextBox.Text.Trim());
                    if (outQ > avQ || outQ == 0)
                    {
                        cMessageBox.Warning("You Cann't Stock Out This Quantity");
                    }
                    else
                    {
                        if (discountPriceTexBox.Text.Trim() != String.Empty ||
                            discountPercentTextBox.Text.Trim() != String.Empty)
                        {
                            if (!dnum.IsMatch(discountPriceTexBox.Text.Trim()) ||
                                !fnum.IsMatch(discountPercentTextBox.Text.Trim()))
                            {
                                cMessageBox.Information("Discount Amount or Percent is Not In Correct Format");
                            }

                        }
                        if (vatPercentTextBox.Text.Trim() != String.Empty)
                        {
                            if (!fnum.IsMatch(vatPercentTextBox.Text.Trim()))
                            {
                                cMessageBox.Information("Vat is not in Correct Format");
                            }

                        }

                        StockOutModel stockOutModel = new StockOutModel();
                        stockOutModel.CatagoryName = catagoryListBox.Text;
                        stockOutModel.CompanyName = companyListBox.Text;
                        stockOutModel.ItemName = ItemListBox.Text;
                        if (!CN.IsMatch(modelBox.Text.Trim()))
                        {
                            stockOutModel.Model = modelBox.Text = "N/A";
                        }
                        else
                        {
                            stockOutModel.Model = modelBox.Text;
                        }
                        stockOutModel.ItemId = Convert.ToInt32(ItemListBox.SelectedValue);
                        stockOutModel.AvailableQuantity = Convert.ToInt32(availAbleQuatityTextBox.Text.Trim());
                        stockOutModel.Quantity = Convert.ToInt32(outQuantityTextBox.Text);
                        if (dnum.IsMatch(discountPriceTexBox.Text.Trim()) ||
                            fnum.IsMatch(discountPercentTextBox.Text.Trim()))
                        {
                            stockOutModel.DiscountPercent = Convert.ToDecimal(discountPercentTextBox.Text.Trim());
                            stockOutModel.DiscountAmount = Convert.ToDecimal(discountPriceTexBox.Text.Trim());
                        }

                        if (fnum.IsMatch(vatPercentTextBox.Text.Trim()))
                        {
                            stockOutModel.Vatpercent = Convert.ToDecimal(vatPercentTextBox.Text.Trim());
                        }
                        stockOutModel.VatAmount = Convert.ToDecimal(vatPriceTextBox.Text);
                        stockOutModel.Price = Convert.ToDecimal(netBillTexBox.Text.Trim());
                        stockOutModel.Date = DateTime.Today;

                        var existItem = listofStockOut.Find(x => x.ItemId == stockOutModel.ItemId);
                        if (existItem != null)
                        {
                            // Avobe code are corretly working
                            int quantity = Convert.ToInt32(existItem.Quantity + stockOutModel.Quantity);
                            if (quantity <= Convert.ToInt32(stockOutModel.AvailableQuantity))
                            {
                                existItem.Quantity += stockOutModel.Quantity;
                                existItem.Price += stockOutModel.Price;
                                stockOutCard.Refresh();

                            }
                            else
                            {
                                cMessageBox.Warning("You cann't Stock Out This Quantity");

                            }

                        }
                        else
                        {
                            listofStockOut.Add(stockOutModel);
                        }

                        ShowCard();
                    }
                }
            }
        }

        public void ShowCard()
        {
            stockOutCard.Rows.Clear();
            if (listofStockOut.OrderBy(order => order.ItemName) != null)
            {
                saleButton.Visible = true;
                lostButton.Visible = true;
                damageButton.Visible = true;
                cardTitle.Text = "Total : " + listofStockOut.Count + " Items Added To Card";
                stockOutCard.ColumnCount = 5;
                stockOutCard.Columns[0].Name = "SL";
                stockOutCard.Columns[1].Name = "Company";
                stockOutCard.Columns[2].Name = "Product";
                stockOutCard.Columns[3].Name = "Quantity";
                stockOutCard.Columns[4].Name = "Price";
                stockOutCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                int rn = 0;
                foreach (StockOutModel stockOut in listofStockOut)
                {
                    int inc = listofStockOut.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    //  
                    stockOutCard.Rows.Add(rn, stockOut.CompanyName, stockOut.ItemName, stockOut.Quantity,
                        stockOut.Price);
                }
            }
        }

        private void stockOutCard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || stockOutCard.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {

                stockOutCard.CurrentRow.Selected = true;
                var product = stockOutCard.Rows[e.RowIndex].Cells["Product"].FormattedValue.ToString();
                stockOutCard.Rows.Clear();
                cardTitle.Text = String.Empty;
                //  var company = stockOutCard.Rows[e.RowIndex].Cells["Company"].FormattedValue.ToString();
                // int price = Convert.ToInt32(stockOutCard.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString());
                var removeItem = listofStockOut.Find(x => x.ItemName == product);
                listofStockOut.Remove(removeItem);
                ShowCard();
            }
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            if (listofStockOut.Count == 0)
            {
                cMessageBox.Warning("Please Add Some Item To Card");
            }
            else
            {
                DialogResult option = MessageBox.Show("Do you want to get voucher?", "Get Voucher?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    customerNameBox.Visible = true;
                    addressTextBox.Visible = true;
                    mnumberBox.Visible = true;
                    nameLabel.Visible = true;
                    addLabel.Visible = true;
                    numberLabel.Visible = true;
                    okButton.Visible = true;
                    cancelButton.Visible = true;
                    LockedforCustomer();
                }
                if (option == DialogResult.No)
                {
                    string message = StockOutByType("Sale");
                    cMessageBox.Success(message);
                    StockOut_Load(sender, e);

                }
                if (option == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void lostButton_Click(object sender, EventArgs e)
        {
            bool isVated = listofStockOut.Any(x => x.VatAmount > 0);
            if (isVated)
            {
                cMessageBox.Warning("Vat or Discount Is Not Applicable for This Transaction");
            }
            else
            {
                string message = StockOutByType("Lost");
                cMessageBox.Success(message);
                StockOut_Load(sender, e);


            }
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            bool isVated = listofStockOut.Any(x => x.VatAmount > 0);
            if (isVated)
            {
                cMessageBox.Warning("Vat or Discount Is Not Applicable for This Transaction");
            }
            else
            {
                string message = StockOutByType("Damaged");
                cMessageBox.Success(message);
                StockOut_Load(sender, e);

            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!Ch.IsMatch(customerNameBox.Text.Trim()) || !MoNu.IsMatch(mnumberBox.Text.Trim()) ||
                !CN.IsMatch(addressTextBox.Text.Trim()))
            {
                cMessageBox.Warning("Pleae fillout all fields correctly");
            }
            else
            {
                MakePdf();
                string message = StockOutByType("Sale");
                cMessageBox.Success(message);
                StockOut_Load(sender, e);


            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            unlockedfor();
        }

        public void unlockedfor()
        {
            customerNameBox.Visible = false;
            addressTextBox.Visible = false;
            mnumberBox.Visible = false;
            nameLabel.Visible = false;
            addLabel.Visible = false;
            numberLabel.Visible = false;
            okButton.Visible = false;
            cancelButton.Visible = false;
            saleButton.Enabled = true;
            lostButton.Visible = true;
            damageButton.Visible = true;
            damageButton.Visible = true;
            addCardButton.Enabled = true;
            discountPercentTextBox.Enabled = true;
            discountPriceTexBox.Enabled = true;
            vatPercentTextBox.Enabled = true;
            catagoryListBox.Enabled = true;
            companyListBox.Enabled = true;
            ItemListBox.Enabled = true;
            outQuantityTextBox.Enabled = true;
            stockOutCard.Enabled = true;
        }

        public void LockedforCustomer()
        {
            saleButton.Enabled = false;
            lostButton.Visible = false;
            damageButton.Visible = false;
            damageButton.Visible = false;
            addCardButton.Enabled = false;
            discountPercentTextBox.Enabled = false;
            discountPriceTexBox.Enabled = false;
            vatPercentTextBox.Enabled = false;
            catagoryListBox.Enabled = false;
            companyListBox.Enabled = false;
            ItemListBox.Enabled = false;
            outQuantityTextBox.Enabled = false;
            stockOutCard.Enabled = false;
        }




        // Action code goes here
        public string StockOutByType(string Type)
        {
            ItemGateway stockOutGateway = new ItemGateway();
            foreach (StockOutModel stockOut in listofStockOut)
            {
                StockOutModel stockOutModel = new StockOutModel();
                stockOutModel.Quantity = stockOut.Quantity;
                stockOutModel.ItemId = stockOut.ItemId;
                stockOutModel.Type = Type;
                stockOutModel.Price = stockOut.Price;
                stockOutModel.Date = stockOut.Date;
                stockOutGateway.StockOut(stockOutModel);
                stockOutGateway.UpdateAfterStockOut(stockOut);
            }
            return "Stock Out Successfully by : " + Type;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StockOut_Load(sender, e);
        }





        public void MakePdf()
        {
            string str1 = DateTime.Today.ToString("u");
            string str2 = str1.Replace(':', 's');
            string str3 = str2.Replace(',', 'd');
            //    string filname = DateTime.Today.ToString("");
            string fileNamePrifix = customerNameBox.Text.Trim();
            string final_fileName = fileNamePrifix + str3;
            string dirctory = Path.GetDirectoryName(@"C:\Users\Public\");
            DirectoryInfo df = new DirectoryInfo(dirctory + @"\voucher\");
            if (df.Exists == false)
            {
                 Directory.CreateDirectory(dirctory + @"\voucher\");
                
            }
            string filePath = df + final_fileName;


            Document document = new Document(PageSize.A4, 75, 75, 75, 75);
            PdfWriter create = PdfWriter.GetInstance(document, new FileStream(filePath + ".pdf", FileMode.Create));
            document.Open();

            // Font Entry
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font hedingfont = new iTextSharp.text.Font(bf, 30, iTextSharp.text.Font.BOLD, BaseColor.BLUE);
            iTextSharp.text.Font smfont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font thfont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font tdfont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font signfont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            signfont.SetColor(23, 45, 12);



            byte[] image = introduce.loadLogo();
            if (image != null)
            {
                Image logo = Image.GetInstance(image);
                logo.SetAbsolutePosition(40, 700);
                logo.ScaleAbsoluteWidth(70);
                logo.ScaleAbsoluteHeight(70);
                document.Add(logo);
            }



            // Customer Data
            Paragraph Header = new Paragraph();
            Header.Alignment = Element.ALIGN_CENTER;


            IntroduceModel introduction = introduce.GetInformation();
            if (introduction != null)
            {
                string instituteBox = introduction.InstituteName;
                string emailBox = introduction.Email;
                string addresss = introduction.Address;
                string web = introduction.WebSite;
                string mobiles = introduction.Mobile;
                string ownerName = introduction.OwnerName;

                Header.Add(new Chunk(instituteBox, hedingfont));
                Header.Add(new Chunk("\n" + addresss, smfont));
                Header.Add(new Chunk("\nCell :" + mobiles + ", \n " + web + " , " + emailBox, smfont));
                document.Add(Header);

            }
            else
            {
                Header.Add(new Chunk("It is Your Institute Name", hedingfont));
                Header.Add(new Chunk("\nSomething Address text will visible here", smfont));
                Header.Add(new Chunk("\nCell : -9087948059830, \n Web: N/A, Email: N/A ", smfont));
                document.Add(Header);
            }

            DottedLineSeparator separator = new DottedLineSeparator();
            separator.LineWidth = 1f;
            Chunk linebreak = new Chunk(separator);
            document.Add(linebreak);


            string customerName = customerNameBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string mobile = mnumberBox.Text.Trim();
            Paragraph csdata = new Paragraph();
            csdata.Alignment = Element.ALIGN_LEFT;
            csdata.Add(new Chunk("Customer Name : " + customerName + "\nAddress : " + address + "\nMabile Number : " + mobile + "\n Date : " + DateTime.Now.ToString("dd/MM/yyyy"), smfont));
            document.Add(csdata);
            DottedLineSeparator separator2 = new DottedLineSeparator();
            separator2.LineWidth = 1f;
            Chunk linebreak2 = new Chunk(separator2);
            document.Add(linebreak2);



            //Write the table
            float[] columnWidths = { 1.5f, 7f, 2.2f, 4f };
            PdfPTable ItemsRecord = new PdfPTable(columnWidths);
            ItemsRecord.DefaultCell.Column.Alignment = Element.ALIGN_CENTER;
            ItemsRecord.WidthPercentage = 100;
            ItemsRecord.DefaultCell.PaddingBottom = 4f;
            ItemsRecord.AddCell(new Phrase("Sl", thfont));
            ItemsRecord.AddCell(new Phrase("Product  Description", thfont));
            ItemsRecord.AddCell(new Phrase("Quantity", thfont));
            ItemsRecord.AddCell(new Phrase("Net Price", thfont));
            //table Data
            var totalQuantity = listofStockOut.Sum(x => x.Quantity);
            var totalamount = listofStockOut.Sum(x => x.Price).ToString(CultureInfo.CreateSpecificCulture("bn-BD"));
            int ci = 0;
            int lc = listofStockOut.Count;
            foreach (var items in listofStockOut)
            {
                if (ci <= lc)
                {
                    ci++;
                }
                ItemsRecord.AddCell(new Phrase(ci.ToString(), tdfont));
                ItemsRecord.AddCell(new Phrase(items.CatagoryName + " : " + items.ItemName + " Sl/Mo:" + items.Model, tdfont));
                ItemsRecord.AddCell(new Phrase(items.Quantity.ToString(), tdfont));
                ItemsRecord.AddCell(new Phrase(items.Price.ToString(), tdfont));
            }
            PdfPCell cell = new PdfPCell(new Phrase("Total :  ", tdfont));
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.Colspan = 2;
            ItemsRecord.AddCell(cell);
            ItemsRecord.AddCell(new Phrase(totalQuantity.ToString(), tdfont));
            ItemsRecord.AddCell(new Phrase(totalamount, tdfont));
            document.Add(ItemsRecord);
            document.Add(new Chunk("\n\n\n"));



            //Author
            Paragraph prgAuthor = new Paragraph();
            prgAuthor.Alignment = Element.ALIGN_CENTER;
            prgAuthor.IndentationLeft = 250f;
            prgAuthor.Add(new Chunk("Received by", signfont));
            prgAuthor.Add(new Chunk("\n" + DateTime.Now.ToString("dd/MM/yyyy"), signfont));
            document.Add(prgAuthor);
            document.Add(new Chunk("\n\n\n"));
            DottedLineSeparator separator4 = new DottedLineSeparator();
            separator4.LineWidth = 1f;
            Chunk linebreak4 = new Chunk(separator4);
            document.Add(linebreak4);

            document.Add(new Chunk("\nN:B: \n"));

            DottedLineSeparator separator5 = new DottedLineSeparator();
            separator5.LineWidth = 1f;
            Chunk linebreak5 = new Chunk(separator5);
            document.Add(linebreak5);

            document.Add(new Chunk("\n"));
            document.Close();
            create.Close();
            System.Diagnostics.Process.Start(filePath + ".pdf");
        }












    }

}
