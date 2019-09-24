using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Gateway
{
    class OthersGateway : ConnectionGateway
    {


        public int SaveInformation(IntroduceModel Introduce)
        {
            try
            {
                Connection.Open();
                string query = "Insert Into Information(Name,InstituteName,Address,Mobile,Email,Website,Welcome) values(@name,@instiName,@address,@mobile,@email,@website,@welcome)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@name", Introduce.OwnerName);
                Command.Parameters.AddWithValue("@instiName", Introduce.InstituteName);
                Command.Parameters.AddWithValue("@address", Introduce.Address);
                Command.Parameters.AddWithValue("@mobile", Introduce.Mobile);
                Command.Parameters.AddWithValue("@email", Introduce.Email);
                Command.Parameters.AddWithValue("@website", Introduce.WebSite);
                Command.Parameters.AddWithValue("@welcome", Introduce.WelcomeNote);
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int uploadLogo(byte[] image)
        {
            try
            {
                Connection.Open();
                string query = "insert into Uploads(Logo) values(@imgdata)";
                Command = new SqlCommand(query, Connection);
                Command.Parameters.AddWithValue("@imgdata", SqlDbType.Image).Value = image;
                int rowAffect = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffect;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public byte[] loadLogo()
        {
            Connection.Open();
            string query = "SELECT TOP 1 * From Uploads ORDER BY Id DESC";
            Command = new SqlCommand(query, Connection);
           Reader = Command.ExecuteReader();
            byte[] imgg = null;
            while (Reader.Read())
            {
                if (!Convert.IsDBNull(Reader["Logo"]))
                {
                    imgg = (byte[])(Reader["Logo"]);
                }
                
               
            }
          
            Connection.Close();
            return imgg;
        }
        public IntroduceModel GetInformation()
        {
            Connection.Open();
            string query = "SELECT TOP 1 * From Information ORDER BY Id DESC";
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            Reader.Read();
            IntroduceModel introduce = null;
            if (Reader.HasRows)
            {
                introduce = new IntroduceModel();
                introduce.OwnerName = Reader["Name"].ToString();
                introduce.InstituteName = Reader["InstituteName"].ToString();
                introduce.WelcomeNote = Reader["Welcome"].ToString();
                introduce.Address = Reader["Address"].ToString();
                introduce.Email = Reader["Email"].ToString();
                introduce.WebSite = Reader["Website"].ToString();
                introduce.Mobile = Reader["Mobile"].ToString();

            }
            Reader.Close();
            Connection.Close();
            return introduce;
        }       
       
    }
}
