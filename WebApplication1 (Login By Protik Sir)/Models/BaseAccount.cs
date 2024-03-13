using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BaseAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool VerifyLogin()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            if (this.UserName == "Nafi" && this.Password == "123456")
            {
               return true;
            }
            return false;
        }
    }
}