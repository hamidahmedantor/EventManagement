using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RegistrationRepository
    {
        DataAccess dataAccess;
        public RegistrationRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Register(string name, string gender, string email, string phone, string address, string username, string password, int type)
        {
            string sql = "INSERT INTO userinfo(name,gender,email,phone,address) VALUES('" + name + "','" + gender + "','" + email + "','" + phone + "','" + address + "')";
            int result = dataAccess.ExecuteQuery(sql);
            if (result > 0)
            {
                dataAccess = new DataAccess();
                sql = "SELECT * FROM userinfo WHERE Email='" + email + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                int id = (int)reader["Id"];

                dataAccess = new DataAccess();
                sql = "INSERT INTO userlogin(username,password,type,uid) VALUES('" + username + "','" + password + "'," + type + "," + id + ")";
                result = dataAccess.ExecuteQuery(sql);
                if (result > 0)
                {
                    return 1;
                }
                else { return 0; }
            }
            else { return 0; }
        }

        //Customer Profile edit
        public User GetUser(Login ln)
        {
            try
            {

                string sql = "select * from userinfo where id = " + ln.UId;

                SqlDataReader dr = dataAccess.GetData(sql);
                dr.Read();
                User customer = new User();
                customer.Id = (int)dr["id"];
                customer.Name = (dr["name"].ToString());
                customer.Gender = (dr["gender"].ToString());
                customer.Email = (dr["email"].ToString());
                customer.Phone = (dr["phone"].ToString());
                customer.Address = (dr["address"].ToString());

                return customer;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
