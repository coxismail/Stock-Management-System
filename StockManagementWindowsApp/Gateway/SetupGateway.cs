using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Gateway
{
    class SetupGateway : ConnectionGateway
    {

        public int SaveCatagory(CatagoryModel catagory)
        {
            try
            {
                Connection.Open();
                string query = "Insert Into Catagories(Name) values(@name)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", catagory.Name);
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }

        }
        public int UpdateCatagory(CatagoryModel catagoryModel)
        {
            try
            {
                string query = "Update Catagories SET Name = @name WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", catagoryModel.Name);
                Command.Parameters.AddWithValue("@id", catagoryModel.Id);
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

        public int DeleteCatagory(string id)
        {
            try
            {
                string query = "Update Catagories SET Active = 0 WHERE  Id= @id";
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
        public int ReactiveCatagory(int id)
        {
            try
            {
                string query = "Update Catagories SET Active = 1 WHERE  Id= @id";
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
        public bool IsExists(CatagoryModel catagory)
        {
            string query = "SELECT * FROM Catagories WHERE Name=@catagory";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catagory", catagory.Name);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

        public List<CatagoryModel> GetAllCatagory()
        {
            List<CatagoryModel> catagoryList = new List<CatagoryModel>();
            String query = "SELECT*FROM Catagories WHERE Active =1";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                CatagoryModel catagroy = new CatagoryModel();
                catagroy.Id = Convert.ToInt32(Reader["Id"]);
                catagroy.Name = Reader["Name"].ToString();
                catagoryList.Add(catagroy);
            }
            Reader.Close();
            Connection.Close();
            return catagoryList;
        }

        public List<CatagoryModel> DeletedCatagory()
        {
            List<CatagoryModel> catagoryList = new List<CatagoryModel>();
            String query = "SELECT*FROM Catagories WHERE Active =0";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                CatagoryModel catagroy = new CatagoryModel();
                catagroy.Id = Convert.ToInt32(Reader["Id"]);
                catagroy.Name = Reader["Name"].ToString();
                catagoryList.Add(catagroy);
            }
            Reader.Close();
            Connection.Close();
            return catagoryList;
        }

        public CountModel CountAll()
        {
            
            String query =
                "SELECT(SELECT COUNT(Name) FROM   Catagories WHERE Active =1) AS TCatagory,(SELECT COUNT(Name) FROM   Companies WHERE Active =1)AS TCompany,(SELECT COUNT(Name)  FROM   Items WHERE Active = 1 ) AS TItem,(SELECT SUM(StockAQ) FROM   Items WHERE Active = 1 )AS TStock,(SELECT SUM(StockAQ*Price) FROM   Items WHERE Active = 1 )AS TPrice";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            CountModel countModel = null;
            Reader.Read();
            if(Reader.HasRows)
            {
                countModel = new CountModel();
                countModel.TotaCatagory = Convert.ToInt32(Reader["TCatagory"]);
                countModel.TotalCompany = Convert.ToInt32(Reader["TCompany"]);
                countModel.TotalItems = Convert.ToInt32(Reader["TItem"]);
                countModel.TotalStock = 0;
                if (!Convert.IsDBNull(Reader["TStock"]))
                {
                    countModel.TotalStock = Convert.ToInt32(Reader["TStock"]);
                }
                countModel.StockPrice = 0;
                if (!Convert.IsDBNull(Reader["TPrice"]))
                {
                    countModel.StockPrice = Convert.ToDecimal(Reader["TPrice"]);
                }
               
            }
            Reader.Close();
            Connection.Close();
            return countModel;

        }

        //Company Section Goes here


        public int SaveCompany(CompanyModel company)
        {
            try
            {
                Connection.Open();
                string query = "Insert Into Companies(Name) values(@name)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", company.Name);
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }

        }
        public int UpdateCompany(CompanyModel companyModel)
        {
            try
            {
                string query = "Update Companies SET Name = @name WHERE  Id= @id";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", companyModel.Name);
                Command.Parameters.AddWithValue("@id", companyModel.Id);
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
        public int DeleteCompany(string id)
        {
            try
            {
                string query = "Update Companies SET Active = 0 WHERE  Id= @id";
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
        public int ReactiveCompany(int id)
        {
            try
            {
                string query = "Update Companies SET Active = 1 WHERE  Id= @id";
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

        public bool IsExistCompany(CompanyModel company)
        {
            string query = "SELECT * FROM Companies WHERE Name=@catagory";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catagory", company.Name);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }
        public List<CompanyModel> GetAllCompany()
        {
            List<CompanyModel> companyList = new List<CompanyModel>();
            String query = "SELECT*FROM Companies WHERE Active=1";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                CompanyModel company = new CompanyModel();
                company.Id = Convert.ToInt32(Reader["Id"]);
                company.Name = Reader["Name"].ToString();
                companyList.Add(company);
            }
            Reader.Close();
            Connection.Close();
            return companyList;
        }
        public List<CompanyModel> DeletedCompany()
        {
            List<CompanyModel> companyList = new List<CompanyModel>();
            String query = "SELECT*FROM Companies WHERE Active=0";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                CompanyModel company = new CompanyModel();
                company.Id = Convert.ToInt32(Reader["Id"]);
                company.Name = Reader["Name"].ToString();
                companyList.Add(company);
            }
            Reader.Close();
            Connection.Close();
            return companyList;
        }

//Items Section Goes here
        public int SaveItem(ItemsModel itemsModel)
        {
            try
            {
                string query = "Insert Into Items(CatagoryId, CompanyId, Name, Price) values(@catagoryid, @Companyid, @name, @price)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@catagoryId", itemsModel.CatagoryID);
                Command.Parameters.AddWithValue("@companyId", itemsModel.CompanyID);
                Command.Parameters.AddWithValue("@name", itemsModel.Name);
                Command.Parameters.AddWithValue("@price", itemsModel.Price);
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

        public bool IsItemExists(ItemsModel itemModel)
        {
            string query = "SELECT * FROM Items WHERE CatagoryId =@catagoryId AND CompanyId =@companyId AND Name =@name AND Price = @price";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@catagoryId", itemModel.CatagoryID);
            Command.Parameters.AddWithValue("@companyId", itemModel.CompanyID);
            Command.Parameters.AddWithValue("@name", itemModel.Name);
            Command.Parameters.AddWithValue("@price", itemModel.Price);
            Connection.Open();
            Reader = Command.ExecuteReader();
            bool isExists = Reader.HasRows;
            Connection.Close();
            return isExists;
        }

    }

}
