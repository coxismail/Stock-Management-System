using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Gateway
{
    class SearchGateway: ConnectionGateway
    {



        public List<SearchViewModel> SearchAll()
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Type= @type GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }

        // Search by Two Date
        public List<SearchViewModel> SearchViewBytwoDate(DateTime FromDate, DateTime ToDate)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Date between @FromDate and @ToDate AND Type =@type GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@fromDate", FromDate);
            Command.Parameters.AddWithValue("@toDate", ToDate);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }




        public List<SearchViewModel> SearchbyDateWithCat(DateTime FromDate, DateTime ToDate, int Catagory)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Date between @FromDate and @ToDate AND Type= @type AND CatagoryID =@catagoryID GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@fromDate", FromDate);
            Command.Parameters.AddWithValue("@toDate", ToDate);
            Command.Parameters.AddWithValue("@catagoryID", Catagory);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyDateWithCom(DateTime FromDate, DateTime ToDate, int company)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Date between @FromDate and @ToDate AND Type= @type AND CompanyID =@companyId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@fromDate", FromDate);
            Command.Parameters.AddWithValue("@toDate", ToDate);
            Command.Parameters.AddWithValue("@companyId", company);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyDateWithCatCom(DateTime FromDate, DateTime ToDate, int Catagory, int company)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Date between @FromDate and @ToDate AND Type= @type AND CatagoryID =@catgoryId AND CompanyID =@companyId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@fromDate", FromDate);
            Command.Parameters.AddWithValue("@toDate", ToDate);
            Command.Parameters.AddWithValue("@catgoryId", Catagory);
            Command.Parameters.AddWithValue("@companyId", company);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyDateWithItem(DateTime FromDate, DateTime ToDate, int Item)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Date between @FromDate and @ToDate AND Type= @type AND ItemId =@itemId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@fromDate", FromDate);
            Command.Parameters.AddWithValue("@toDate", ToDate);
            Command.Parameters.AddWithValue("@itemId", Item);
 
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        // Without Date
        public List<SearchViewModel> SearchbyCatagory(int Catagory)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Type= @type AND CatagoryID =@catagoryID GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catagoryID", Catagory);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyCompany(int company)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Type= @type AND CompanyID = @companyId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@companyId", company);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyCatagoryandCompany(int Catagory, int company)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Type= @type AND CatagoryID =@catgoryId AND CompanyID =@companyId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catgoryId", Catagory);
            Command.Parameters.AddWithValue("@companyId", company);
            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
        public List<SearchViewModel> SearchbyItem(int Item)
        {
            string query = "SELECT CatagoryName, CompanyName, ItemName, Count(Quantity) AS Quantity, SUM(Price) AS Price FROM StockOutView WHERE Type= @type AND ItemId =@itemId GROUP BY ItemName,CatagoryName, CompanyName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@itemId", Item);

            Command.Parameters.AddWithValue("@type", "Sale");
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }

// Search all stock Out Data
        public List<SearchViewModel> AllStockOut()
        {
            string query = "SELECT * FROM StockOutView";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<SearchViewModel> searchResults = new List<SearchViewModel>();
            while (Reader.Read())
            {
                SearchViewModel searchResult = new SearchViewModel();
                searchResult.ItemName = Reader["ItemName"].ToString();
                searchResult.CompanyName = Reader["CompanyName"].ToString(); ;
                searchResult.CatagoryName = Reader["CatagoryName"].ToString();
                searchResult.Price = Convert.ToDecimal(Reader["Price"].ToString());
                searchResult.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchResult.Type =Reader["Type"].ToString();
                searchResult.Date = Convert.ToDateTime(Reader["Date"]);
                searchResults.Add(searchResult);
            }

            Connection.Close();

            return searchResults;
        }
    }
}
