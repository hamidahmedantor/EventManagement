using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repositories
{
    public class VenueRepository : IRepository<Venue>, IDisposable
    {
        DataAccess dataAccess;
        public VenueRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Venue> GetAll()
        {
            string sql = "SELECT * FROM venue";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Venue> venue = new List<Venue>();
            while (reader.Read())
            {
                Venue venues = new Venue();
                venues.Id = (int)reader["id"];
                venues.Name = reader["name"].ToString();
                venues.Place = reader["place"].ToString();
                venues.Cost = Convert.ToDouble(reader["cost"]);
                venues.Contact = reader["contact"].ToString();
                venue.Add(venues);
            }
            return venue;
        }

        public Venue Get(int id)
        {
            string sql = "SELECT * FROM venue WHERE id=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Venue v = new Venue();
            v.Id = (int)reader["id"];
            v.Name = reader["name"].ToString();
            v.Place = reader["place"].ToString();
            v.Cost = Convert.ToDouble(reader["cost"]);
            v.Contact = reader["contact"].ToString();
            dataAccess.Dispose();
            return v;

        }

        public Venue Get(string name)
        {
            string sql = "SELECT * FROM venue WHERE Name='" + name + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Venue v = new Venue();
            v.Id = (int)reader["id"];
            v.Name = reader["name"].ToString();
            v.Place = reader["place"].ToString();
            v.Cost = Convert.ToDouble(reader["cost"]);
            v.Contact = reader["contact"].ToString();
            dataAccess.Dispose();
            return v;

        }

        public int Insert(Venue entity)
        {
            //dataAccess =new DataAccess();
            string sql = "insert into venue(name,place,cost,contact) values('" + entity.Name + "','" + entity.Place + "'," + entity.Cost + ",'" + entity.Contact + "')";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Venue entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE venue SET name='" + entity.Name + "',place='" + entity.Place + "',cost=" + entity.Cost + ",contact='" + entity.Contact + "' WHERE id=" + entity.Id ;
            return dataAccess.ExecuteQuery(sql);
        }

        public int delete(int id)
        {

            string sql = "delete from venue where id=" + id;
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
