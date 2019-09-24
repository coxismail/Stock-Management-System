using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Gateway
{
    class ItemGateway : ConnectionGateway
    {
        public int UpdateItem(ItemsModel items)
        {
            try
            {
                string query = "Update Items SET Name = @name , Price = @price WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", items.Name);
                Command.Parameters.AddWithValue("@price", items.Price);
                Command.Parameters.AddWithValue("@id", items.Id);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }
    
        }

        public int DeleteItem(string id)
        {
            try
            {
                string query = "Update Items SET Active = 0 WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@id", id);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int ReActiveItem(string id)
        {
            try
            {
                string query = "Update Items SET Active = 1 WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@id", id);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public List<ItemsModel> GetItemsByCompanyID(int Id)
        {
            List<ItemsModel> ItemsList = new List<ItemsModel>();
            String query = "SELECT*FROM Items WHERE CompanyId=@companyid AND Active=1";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@companyid", Id);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemsModel ItemRelator = new ItemsModel();
                ItemRelator.Id = Convert.ToInt32(Reader["Id"]);
                ItemRelator.Name = Reader["Name"].ToString();
                ItemRelator.Price = Convert.ToInt32(Reader["Price"]);
                ItemRelator.StockAQ = Convert.ToInt32(Reader["StockAQ"]);
                ItemsList.Add(ItemRelator);
            }
            Reader.Close();
            Connection.Close();
            return ItemsList;
        }


        public List<ItemsModel> GetItemsByCatagoryID(int Id)
        {
            List<ItemsModel> ItemsList = new List<ItemsModel>();
            String query = "SELECT*FROM Items WHERE CatagoryID=@Id AND Active=1";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Id", Id);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.Id = Convert.ToInt32(Reader["Id"]);
                itemsModel.Name = Reader["Name"].ToString();
                itemsModel.Price = Convert.ToInt32(Reader["Price"]);
                itemsModel.StockAQ = Convert.ToInt32(Reader["StockAQ"]);
                ItemsList.Add(itemsModel);
            }
            Reader.Close();
            Connection.Close();
            return ItemsList;
        }



        public List<ItemsModel> GetItemsByCompanyandCatagoryID(int catagoryid, int companyid)
        {
            List<ItemsModel> ItemsList = new List<ItemsModel>();
            String query = "SELECT*FROM Items WHERE CompanyId=@companyid AND CatagoryID = @catagoryid AND Active=1";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catagoryid", catagoryid);
            Command.Parameters.AddWithValue("@companyid", companyid);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.Id = Convert.ToInt32(Reader["Id"]);
                itemsModel.Name = Reader["Name"].ToString();
                itemsModel.Price = Convert.ToInt32(Reader["Price"]);
                itemsModel.StockAQ = Convert.ToInt32(Reader["StockAQ"]);
                ItemsList.Add(itemsModel);
            }
            Reader.Close();
            Connection.Close();
            return ItemsList;
        }

        public ItemsModel GetItemsByID(int Id)
        {
            String query = "SELECT*FROM Items WHERE Id= @itemID AND Active =1";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@itemID", Id);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Reader.Read();
            ItemsModel ItemRelator = null;
            if (Reader.HasRows)
            {
                ItemRelator = new ItemsModel();
                ItemRelator.Price = Convert.ToInt32(Reader["Price"]);
                ItemRelator.StockAQ = Convert.ToInt32(Reader["StockAQ"]);
                ItemRelator.Id = Convert.ToInt32(Reader["Id"]);
            }
            Reader.Close();
            Connection.Close();
            return ItemRelator;
        }
        public List<ItemsModel> GetAllItems()
        {
            List<ItemsModel> itemlist = new List<ItemsModel>();
            String query = "SELECT* FROM TotalItems";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemsModel ItemRelator = new ItemsModel();
                ItemRelator.Catagory = Reader["Catagory"].ToString();
                ItemRelator.Company = Reader["Company"].ToString();
                ItemRelator.Name = Reader["Company"].ToString();
                ItemRelator.StockAQ = Convert.ToInt32(Reader["StockAQ"]);
                ItemRelator.Price = Convert.ToInt32(Reader["Price"]);
                itemlist.Add(ItemRelator);
            }
            Reader.Close();
            Connection.Close();
            return itemlist;
        }
        public List<ItemsModel> DeletedItems()
        {
            List<ItemsModel> DeletedItems = new List<ItemsModel>();
            String query = "SELECT*FROM Items WHERE Active = 0 ";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ItemsModel itemsModel = new ItemsModel();
                itemsModel.Id = Convert.ToInt32(Reader["Id"]);
                itemsModel.Name = Reader["Name"].ToString();
                DeletedItems.Add(itemsModel);
            }

            Reader.Close();
            Connection.Close();
            return DeletedItems;
        }

        public int StockIn(ItemsModel stockIn)
        {
            try
            {
                string query = "UPDATE Items SET StockAQ+= @stockinQ WHERE Id= @ItemsId";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@stockinQ", stockIn.StockAQ);
                Command.Parameters.AddWithValue("@ItemsId", stockIn.Id);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int StockOut(StockOutModel stockout)
        {
            try
            {
                string query = "INSERT INTO StockOut(ItemId, Type, Quantity, Price, Date) VALUES(@itemid, @type, @quantity, @price, @date)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@itemid", stockout.ItemId);
                Command.Parameters.AddWithValue("@type", stockout.Type);
                Command.Parameters.AddWithValue("@quantity", stockout.Quantity);
                Command.Parameters.AddWithValue("@price", stockout.Price);
                Command.Parameters.AddWithValue("@date", stockout.Date);

                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }
     
        }

        public int UpdateAfterStockOut(StockOutModel stockout)
        {
            try
            {
                string query = "Update Items SET StockAQ -=@availQ WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@availQ", stockout.Quantity);
                Command.Parameters.AddWithValue("@id", stockout.ItemId);
                Connection.Open();
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }
   
        }

    }
}
