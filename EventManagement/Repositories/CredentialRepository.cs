using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CredentialRepository
    {
        DataAccess dataAccess;
        public CredentialRepository()
        {
            dataAccess = new DataAccess();
        }

        public Login Validation(Login ln)
        {
            string sql = "SELECT * FROM userlogin WHERE username='" + ln.Username + "' AND password='" + ln.Password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            ln.Id = (int)reader["id"];
            ln.Username = reader["username"].ToString();
            ln.Password = reader["password"].ToString();
            ln.UserType = (int)reader["type"];
            ln.UId = (int)reader["uid"];

            return ln;
        }
    }
}
