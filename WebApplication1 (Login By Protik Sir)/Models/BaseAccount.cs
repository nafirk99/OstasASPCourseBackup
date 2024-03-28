using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dataTable = new DataTable();
            string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            
            SqlConnection sqlConnection = new SqlConnection(ConnString);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = "";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            cmd.Dispose();
            sqlConnection.Close();

            if (this.UserName == "Nafi" && this.Password == "123456")
            {
               return true;
            }
            return false;
        }
    }
}