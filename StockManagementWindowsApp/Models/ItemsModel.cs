using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementWindowsApp.Models
{
    public class ItemsModel
    {
        public int Id { get; set; }
        public int CatagoryID { get; set; }
        public string Catagory { get; set; }
        public int CompanyID { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal StockAQ { get; set; }
    }
}
