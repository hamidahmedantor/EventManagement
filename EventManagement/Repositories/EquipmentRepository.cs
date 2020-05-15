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
    public class EquipmentRepository : IRepository<Equipment>, IDisposable
    {
        DataAccess dataAccess;
        public EquipmentRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Equipment> GetAll()
        {
            string sql = "SELECT * FROM equipment";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Equipment> f = new List<Equipment>();
            while (reader.Read())
            {
                Equipment e = new Equipment();
                e.Id = (int)reader["id"];
                e.Name = reader["name"].ToString();
                e.Cost = Convert.ToDouble(reader["cost"]);
                f.Add(e);
            }
            return f;
        }

        public Equipment Get(int id)
        {
            string sql = "SELECT * FROM equipment WHERE id=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Equipment eq=new Equipment();
            eq.Id = (int)reader["id"];
            eq.Name = reader["name"].ToString();
            eq.Cost = Convert.ToDouble(reader["cost"]);
            dataAccess.Dispose();
            return eq;

        }

        public Equipment Get(string name)
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM equipment WHERE name='" + name + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Equipment eq = new Equipment();
            eq.Id = (int)reader["id"];
            eq.Name = reader["name"].ToString();
            eq.Cost = Convert.ToDouble(reader["cost"]);
            dataAccess.Dispose();
            return eq;

        }

        public int Insert(Equipment entity)
        {
            //dataAccess =new DataAccess();
            string sql = "insert into equipment(name,cost) values('" + entity.Name + "'," + entity.Cost + ")";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Equipment entity)
        {
            dataAccess = new DataAccess();
            string sql = "UPDATE equipment SET name='" + entity.Name + "',cost=" + entity.Cost + " WHERE id=" + entity.Id;
            return dataAccess.ExecuteQuery(sql);
        }

        public int delete(int id)
        {

            string sql = "delete from equipment where id=" + id;
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
