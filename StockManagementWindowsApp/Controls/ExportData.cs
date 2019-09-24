using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Controls
{
    public partial class ExportData : UserControl
    {
        private CMessageBox cMessageBox = new CMessageBox();
        public static ExportData _instance;

        public static ExportData instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ExportData();
                return _instance;
            }
        }
        public ExportData()
        {
            InitializeComponent();
        }

        public void ShowList()
        {
            ItemGateway itemGateway = new ItemGateway();
            List<ItemsModel> itemslist = null;
            itemsGridview.Rows.Clear();
             itemslist = itemGateway.GetAllItems();
             if (itemslist != null)
            {
               
                itemsGridview.ColumnCount = 7;
                itemsGridview.Columns[0].Name = "SL";
                itemsGridview.Columns[0].Width = 60;
                itemsGridview.Columns[1].Name = "Category";
                itemsGridview.Columns[1].Width = 60;                
                itemsGridview.Columns[2].Name = "Company";
                itemsGridview.Columns[2].Width = 60;
                itemsGridview.Columns[3].Name = "Items Name";
                itemsGridview.Columns[3].Width = 100;
                itemsGridview.Columns[4].Name = "Price";
                itemsGridview.Columns[4].Width = 100;
                itemsGridview.Columns[5].Name = "Av. Quantity";
                itemsGridview.Columns[5].Width = 100;                
                itemsGridview.Columns[6].Name = "Total Price";
                itemsGridview.Columns[6].Width = 100;
                
               
                int rn = 0;
                foreach (ItemsModel items in itemslist)
                {
                    int inc = itemslist.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    itemsGridview.Rows.Add(rn, items.Catagory, items.Company, items.Name, items.Price, items.StockAQ, items.Price*items.StockAQ);
                }
            }
        }

        public void ListofStockOut()
        {
           SearchGateway StockOut = new SearchGateway();
            List<SearchViewModel> listofStockOut = null;
            salseGridview.Rows.Clear();
                 listofStockOut = StockOut.AllStockOut();
            if (listofStockOut != null)
            {
                salseGridview.ColumnCount = 8;
                salseGridview.Columns[0].Name = "SL";
                salseGridview.Columns[0].Width = 20;
                salseGridview.Columns[1].Name = "Category";
                salseGridview.Columns[1].Width = 30;
                salseGridview.Columns[2].Name = "Company";
                salseGridview.Columns[2].Width = 30;
                salseGridview.Columns[3].Name = "Items Name";
                salseGridview.Columns[3].Width = 50;
                salseGridview.Columns[4].Name = "Quantity";
                salseGridview.Columns[4].Width = 50;
                salseGridview.Columns[5].Name = "Price";
                salseGridview.Columns[5].Width = 50;
                salseGridview.Columns[6].Name = "Type of Stock Out";
                salseGridview.Columns[6].Width = 50;                
                salseGridview.Columns[7].Name = "Date";
                salseGridview.Columns[7].Width = 50;
    
                int rn = 0;
                foreach (SearchViewModel sales in listofStockOut)
                {
                    int inc = listofStockOut.Count;
                    if (inc > rn)
                    {
                        rn++;
                    }
                    salseGridview.Rows.Add(rn, sales.CatagoryName, sales.CompanyName,sales.ItemName,sales.Quantity, sales.Price,sales.Type,sales.Date);
                }
            }
        }
        private void ExportData_Load(object sender, EventArgs e)
        {
            itemsGridview.Visible = false;
            salseGridview.Visible = false;
            ShowList();
            ListofStockOut();

        }



        // Export Items Data 
        public void ExportExcel()
        {
            if (itemsGridview.Rows.Count !=0 || salseGridview.Rows.Count != 0)
            {
                // creating Excel Application 
                _Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application 
                _Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook 
                _Worksheet worksheet = null;

                if (itemsGridview.Rows.Count != 0)
                {
                    worksheet = workbook.Worksheets[1];
                    worksheet.Name = "Stock_Data";
                    for (int i = 1; i < itemsGridview.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = itemsGridview.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet 
                    for (int i = 0; i < itemsGridview.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < itemsGridview.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = itemsGridview.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                if (salseGridview.Rows.Count != 0)
                {
                    worksheet = workbook.Worksheets[2];
                    worksheet.Name = "Stock_Out_History";
                    for (int i = 1; i < salseGridview.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = salseGridview.Columns[i - 1].HeaderText;
                    }
                    // storing Each row and column value to excel sheet 
                    for (int i = 0; i < salseGridview.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < salseGridview.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = salseGridview.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                app.Visible = true;

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Export Stock and Sales Management Data";
                saveFileDialog.DefaultExt = ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
               XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
               Type.Missing, Type.Missing);
                }

                // Exit from the application 
                app.Quit();
            }
            else
            {
                cMessageBox.Information("No Data Found To Export");
            }
            }

           






















        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }










    }








}
