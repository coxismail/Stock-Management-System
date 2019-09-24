using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementWindowsApp.Models
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewUserName { get; set; }
        public string NewPassword { get; set; }

    }

    class RegisterModel
    {
        public string ActivationCode { get; set; }
        public DateTime ActivationDate { get; set; }
        public int Active { get; set; }
    }
}
