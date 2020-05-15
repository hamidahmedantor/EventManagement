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
    public class FoodRepository : IRepository<Food>, IDisposable
    {
        DataAccess dataAccess;
        public FoodRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Food> GetAll()
        {
            string sql = "SELECT * FROM food";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Food> f = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.Id = (int)reader["id"];
                food.Name = reader["name"].ToString();
                food.Cost = Convert.ToDouble(reader["cost"]);
                f.Add(food);
            }
            return f;
        }

        public Food Get(int id)
        {
            string sql = "SELECT * FROM food WHERE id=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Food f = new Food();
            f.Id = (int)reader["id"];
            f.Name = reader["name"].ToString();
            f.Cost = Convert.ToDouble(reader["cost"]);
            dataAccess.Dispose();
            return f;

        }

        public Food Get(string name)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM food WHERE name='" + name + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Food fd = new Food();
            fd.Id = (int)reader["id"];
            fd.Name = reader["name"].ToString();
            fd.Cost = Convert.ToDouble(reader["cost"]);
            dataAccess.Dispose();
            return fd;

        }

        public int Insert(Food entity)
        {
            //dataAccess =new DataAccess();
            string sql = "insert into food(name,cost) values('" + entity.Name + "'," + entity.Cost + ")";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Food entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE food SET name='" + entity.Name + "',cost=" + entity.Cost + " WHERE id=" + entity.Id;
            return dataAccess.ExecuteQuery(sql);
        }

        public int delete(int id)
        {

            string sql = "delete from food where id=" + id;
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
