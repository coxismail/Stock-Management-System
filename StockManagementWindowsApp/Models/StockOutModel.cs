using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementWindowsApp.Controls;

namespace StockManagementWindowsApp.Models
{

    class StockOutModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string CompanyName { get; set; }
        public string CatagoryName { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public decimal Vatpercent { get; set; }
        public decimal VatAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }

    }

    class CountModel
    {
        public int TotaCatagory { get; set; }
        public int TotalCompany { get; set; }
        public int TotalItems { get; set; }
        public int TotalStock { get; set; }
        public decimal StockPrice { get; set; }
    }

  public  class SearchViewModel
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public string CatagoryName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }

    class IntroduceModel
    {
        public string OwnerName  { get; set; }
        public string InstituteName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string WelcomeNote { get; set; }
        public string WebSite { get; set; }
        public string   Address  { get; set; }
        public DateTime ActiveDate { get; set; }
    }
}
