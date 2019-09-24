using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementWindowsApp.Models;

namespace StockManagementWindowsApp.Gateway
{
    class UserGateway : ConnectionGateway
    {
        public bool isVaildUser(User user)
        {
            Connection.Open();

            string query = "SELECT UserName, Password from UserTable WHERE UserName = @userName AND Password = @password";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@userName", user.UserName);
            Command.Parameters.AddWithValue("@password", user.Password);
            Reader = Command.ExecuteReader();
            bool isValidUser = Reader.HasRows;
            Connection.Close();
            return isValidUser;
        }

        public int ChangePassword(User user)
        {
            Connection.Open();
            string query = "UPDATE UserTable SET UserName = @userName, Password= @password WHERE UserName = @puserName";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@userName", user.NewUserName);
            Command.Parameters.AddWithValue("@puserName", user.UserName);
            Command.Parameters.AddWithValue("@password", user.NewPassword);
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }


       // used to register db
        public bool isAlreadySent()
        {
            Connection.Open();
            string query = "SELECT TOP 1 Code, Active from Register WHERE Active = 0 ORDER BY Id DESC";
            Command = new SqlCommand(query, Connection);
            Reader = Command.ExecuteReader();
            bool isAlreadySent = Reader.HasRows;
            Connection.Close();
            return isAlreadySent;
        }
        public int Active(RegisterModel register)
        {
            Connection.Open();
            string query = "UPDATE Register SET Active = 1, ActiveDate = @activedate WHERE Code = @code";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@activedate", register.ActivationDate);
            Command.Parameters.AddWithValue("@code", register.ActivationCode);
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }
        public int InsertCode(string register)
        {
            Connection.Open();
            string query = "INSERT INTO Register(Code, ActiveDate, Active) Values(@actveCode, @activationate, @active)";
            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@actveCode", register);
            Command.Parameters.AddWithValue("@activationate", "2019-08-30");
            Command.Parameters.AddWithValue("@active", "0");
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }
        public DateTime GetRegistrationDate()
        {
            Connection.Open();
            string query = "SELECT TOP 1 Code, ActiveDate from Register WHERE Active = 1 ORDER BY Id DESC";
                Command = new SqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                DateTime Date = Convert.ToDateTime("2018-09-30");
                if (Reader.HasRows)
                {
                    Reader.Read();
                    Date = Convert.ToDateTime(Reader["ActiveDate"]);
                }
                Connection.Close();
                return Date;
            
          
            
        }
    }
}
