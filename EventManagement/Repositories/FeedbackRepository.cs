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
    public class FeedbackRepository : IFeedback<Feedback>
    {
        DataAccess dataAccess;
        public FeedbackRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Feedback> GetAll()
        {
            string sql = "SELECT * FROM feedback";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Feedback> feedbacks = new List<Feedback>();
            while (reader.Read())
            {
                Feedback feedback = new Feedback();
                feedback.Id = (int)reader["fid"];
                feedback.Feedback_Details = reader["Feedback_Details"].ToString();
                feedback.Bid = reader["bid"].ToString();
                feedback.Event_Type = reader["event_type"].ToString();

                feedbacks.Add(feedback);
            }
            return feedbacks;
        }

        public Feedback Get(int id)
        {
            string sql = "SELECT * FROM feedback WHERE Id=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Feedback feedback = new Feedback();
            feedback.Id = (int)reader["Id"];
            feedback.Feedback_Details = reader["Feedback_Details"].ToString();
            feedback.Event_Type = reader["event_type"].ToString();
            dataAccess.Dispose();
            return feedback;

        }

        public Feedback Get(string details)
        {
            string sql = "SELECT * FROM feedback WHERE Feedback_Details='" + details + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Feedback feedback = new Feedback();
            feedback.Id = (int)reader["Id"];
            feedback.Feedback_Details = reader["Feedback_Details"].ToString();
            feedback.Event_Type = reader["event_type"].ToString();
            return feedback;

        }

        public int Insert(Feedback entity)
        {
            string sql = "INSERT INTO Feedback(Feedback_Details,bid,event_type) VALUES('" + entity.Feedback_Details + "','" + entity.Id + "','" + entity.Event_Type + "')";
            return dataAccess.ExecuteQuery(sql);
        }
    }
}