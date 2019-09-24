using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StockManagementWindowsApp.Gateway
{
    class ConnectionGateway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        public ConnectionGateway()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            Connection = new SqlConnection(connectionString);
        }
    }
}
