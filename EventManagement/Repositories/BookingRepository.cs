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
    public class BookingRepository : IBooking<Booking>, IDisposable
    {
        DataAccess dataAccess;
        public BookingRepository()
        {
            dataAccess = new DataAccess();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public List<Booking> GetAll()
        {
            string sql = "SELECT * FROM BookEvent1 where Status="+2;
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Booking> b = new List<Booking>();
            while (reader.Read())
            {
                Booking book = new Booking();
                book.Id = (int)reader["id"];
                book.EventType = reader["EventType"].ToString();
                book.Vanue = reader["Venue"].ToString();
                book.Date = reader["Date"].ToString();
                book.NoOfGuest = Convert.ToInt32(reader["NoGuest"]);
                book.Status = Convert.ToInt32(reader["Status"]);
                book.SelectedFood = reader["Food"].ToString();
                book.SelectedEquipment = reader["Equipment"].ToString();
                book.Cost = Convert.ToDouble(reader["Cost"]);
                b.Add(book);
            }
            return b;
        }
        public List<Booking> GetAlls()
        {
            try
            {
                string sql = "SELECT * FROM BookEvent1";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Booking> b = new List<Booking>();
                while (reader.Read())
                {
                    TimeSpan timeDiff = Convert.ToDateTime(reader["Date"]) - DateTime.Now;
                    if (timeDiff.TotalDays <= 10)
                    {
                        Booking book = new Booking();
                        book.Id = (int)reader["id"];
                        book.EventType = reader["EventType"].ToString();
                        book.Vanue = reader["Venue"].ToString();
                        book.Date = reader["Date"].ToString();
                        book.NoOfGuest = Convert.ToInt32(reader["NoGuest"]);
                        book.Status = Convert.ToInt32(reader["Status"]);
                        book.SelectedFood = reader["Food"].ToString();
                        book.SelectedEquipment = reader["Equipment"].ToString();
                        book.Cost = Convert.ToDouble(reader["Cost"]);
                        b.Add(book);
                    }
                }
                return b;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int Update(Booking entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE BookEvent1 SET Status="+1+" WHERE id=" + entity.Id;
            return dataAccess.ExecuteQuery(sql);
        }
        public int Update1(int id, double p)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE BookEvent1 SET Cost=Cost-" + p + " WHERE id=" + id;
            return dataAccess.ExecuteQuery(sql);
        }


            public int Insert(Booking entity)
        {
            //dataAccess =new DataAccess();
            string sql = "insert into BookEvent1 (EventType,Venue,Date,NoGuest,Status,Food,Equipment,Cost) values('"+entity.EventType+"','"+entity.Vanue+"','"+entity.Date+"',"+entity.NoOfGuest+","+entity.Status+",'"+entity.SelectedFood+"','"+entity.SelectedEquipment+"',"+entity.Cost+")";
            return dataAccess.ExecuteQuery(sql);
        }
            public Booking Get(int id)
            {
                string sql = "SELECT * FROM BookEvent1 WHERE id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Booking book = new Booking();
                book.Id = (int)reader["id"];
                book.EventType = reader["EventType"].ToString();
                book.Vanue = reader["Venue"].ToString();
                book.Date = reader["Date"].ToString();
                book.NoOfGuest = Convert.ToInt32(reader["NoGuest"]);
                book.Status = Convert.ToInt32(reader["Status"]);
                book.SelectedFood = reader["Food"].ToString();
                book.SelectedEquipment = reader["Equipment"].ToString();
                book.Cost = Convert.ToDouble(reader["Cost"]);
                dataAccess.Dispose();
                return book;

            }
            public int delete(int id)
            {

                string sql = "delete from BookEvent1 where id=" + id;
                return dataAccess.ExecuteQuery(sql);
            }

    }
}
