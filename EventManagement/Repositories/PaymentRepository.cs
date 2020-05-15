using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PaymentRepository : IPayment<Payment>, IDisposable
    {
        DataAccess dataAccess;
        public PaymentRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Payment> GetAll()
        {
            string sql = "SELECT * FROM payment1";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Payment> p = new List<Payment>();
            while (reader.Read())
            {
                Payment pay = new Payment();
                pay.Pid = (int)reader["pid"];
                pay.NameOnCard = reader["nameoncard"].ToString();
                pay.Bid = (int)reader["bid"];
                pay.Payments = (double)reader["payment"];
                //pay.Pid = (int)reader["id"];
                //pay.Pid = (int)reader["id"];
                p.Add(pay);
            }
            return p;
        }

        //public Food Get(int id)
        //{
        //    string sql = "SELECT * FROM food WHERE id=" + id;
        //    SqlDataReader reader = dataAccess.GetData(sql);
        //    reader.Read();
        //    Food f = new Food();
        //    f.Id = (int)reader["id"];
        //    f.Name = reader["name"].ToString();
        //    f.Cost = Convert.ToDouble(reader["cost"]);
        //    dataAccess.Dispose();
        //    return f;

        //}

        //public Food Get(string name)
        //{
        //    dataAccess = new DataAccess();
        //    string sql = "SELECT * FROM food WHERE name='" + name + "'";
        //    SqlDataReader reader = dataAccess.GetData(sql);
        //    reader.Read();
        //    Food fd = new Food();
        //    fd.Id = (int)reader["id"];
        //    fd.Name = reader["name"].ToString();
        //    fd.Cost = Convert.ToDouble(reader["cost"]);
        //    dataAccess.Dispose();
        //    return fd;

        //}

        public int Insert(Payment entity)
        {
            //dataAccess =new DataAccess();
            string sql = "insert into payment1(cardno,cvvno,nameoncard,expdate,bid,payment) values("+entity.CardNo+","+entity.CvvNo+",'"+entity.NameOnCard+"','"+entity.ExpDate+"',"+entity.Bid+","+entity.Payments+")";
            return dataAccess.ExecuteQuery(sql);
        }

        //public int Update(Food entity)
        //{
        //    dataAccess = new DataAccess();
        //    string sql = "UPDATE food SET name='" + entity.Name + "',cost=" + entity.Cost + " WHERE id=" + entity.Id;
        //    return dataAccess.ExecuteQuery(sql);
        //}

        //public int delete(int id)
        //{

        //    string sql = "delete from food where id=" + id;
        //    return dataAccess.ExecuteQuery(sql);
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
