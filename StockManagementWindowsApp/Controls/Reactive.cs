using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using StockManagementWindowsApp.Gateway;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Controls
{
    
    public partial class Reactive : UserControl
    {
        CMessageBox cMessageBox = new CMessageBox();
        public Reactive()
        {
            InitializeComponent();
        }
        private static Reactive _instance;

        public static Reactive instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reactive();
                    return _instance;

            }
        }
        SetupGateway setupGateway = new SetupGateway();
        ItemGateway itemGateway = new ItemGateway();
        public void DeletedCatagories()
        {
            List<CatagoryModel> catagorylist = setupGateway.DeletedCatagory();
            if (catagorylist != null)
            {
                //  totalCatagoryLabel.Text = "TotaL : " + catagorylist.Count + " Catagories Found";
                catagoryGridview.ColumnCount = 2;
                catagoryGridview.Columns[0].Name = "ID";
                catagoryGridview.Columns[0].Width = 60;
                catagoryGridview.Columns[1].Name = "Category Name";
                catagoryGridview.Columns[1].Width = 200;
             //   catagoryGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (CatagoryModel catagory in catagorylist)
                {
                    catagoryGridview.Rows.Add(catagory.Id, catagory.Name);
                }
            }
        }
        public void DeletedCompany()
        {
            List<CompanyModel> companyList = setupGateway.DeletedCompany();
            if (companyList != null)
            {
                // totalCompanyLabel.Text = "Total : " + companyList.Count + " Companies Found";
                companyGridview.ColumnCount = 2;
                companyGridview.Columns[0].Name = "ID";
                companyGridview.Columns[0].Width = 60;
                companyGridview.Columns[1].Name = "Company Name";
                companyGridview.Columns[1].Width = 200;
            //    companyGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (CompanyModel company in companyList)
                {
                    companyGridview.Rows.Add(company.Id, company.Name);

                }

            }
        }
        public void DeletedItems()
        {

            List<ItemsModel> itemlist = itemGateway.DeletedItems();
            if (itemlist != null)
            {
                // totalItemsLabel.Text = "TotaL : " + itemlist.Count + " Items For This " + es;
                itemsGridView.ColumnCount = 2;
                itemsGridView.Columns[0].Name = "ID";
                itemsGridView.Columns[0].Width = 70;
                itemsGridView.Columns[1].Name = "Items Name";
                itemsGridView.Columns[1].Width = 200;
              //  itemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (ItemsModel items in itemlist)
                {
                    itemsGridView.Rows.Add(items.Id, items.Name);
                }
            }
        }
        private void Reactive_Load(object sender, EventArgs e)
        {
            catagoryGridview.Rows.Clear();
            companyGridview.Rows.Clear();
            itemsGridView.Rows.Clear();

            DeletedCatagories();
            DeletedCompany();
            DeletedItems();
        }

        private void itemsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || itemsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {
                itemsGridView.CurrentRow.Selected = true;
                string Name = itemsGridView.Rows[e.RowIndex].Cells["Items Name"].FormattedValue.ToString().Trim();
               string id = itemsGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString().Trim();
               itemGateway.ReActiveItem(id);
                cMessageBox.Success("Item Reactivated");
                Reactive_Load(sender,e);
            }
        }

        private void companyGridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || companyGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {

                companyGridview.CurrentRow.Selected = true;
                String Name = companyGridview.Rows[e.RowIndex].Cells["Company Name"].FormattedValue.ToString().Trim();
                int id = Convert.ToInt32(companyGridview.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString().Trim());
                setupGateway.ReactiveCompany(id);
                cMessageBox.Success("Company Re-Activated");
                Reactive_Load(sender, e);
            }
        }

        private void catagoryGridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || catagoryGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            {
                catagoryGridview.CurrentRow.Selected = true;
                string Name = catagoryGridview.Rows[e.RowIndex].Cells["Category Name"].FormattedValue.ToString().Trim();
                int id = Convert.ToInt32(catagoryGridview.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString().Trim());
                setupGateway.ReactiveCatagory(id);
                cMessageBox.Success("Category Reactivated");
                Reactive_Load(sender, e);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Reactive_Load(sender, e);
        }

    }
}
