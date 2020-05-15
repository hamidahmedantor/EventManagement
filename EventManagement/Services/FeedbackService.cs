using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services
{
    public class FeedbackService
    {
        FeedbackRepository feedRepo;
        public FeedbackService()
        {
            feedRepo = new FeedbackRepository();
        }

        public List<Feedback> GetAllFeedbacks()
        {
            return feedRepo.GetAll();
        }
        public Feedback GetById(int id)
        {
            return feedRepo.Get(id);
        }
        public Feedback GetByDetails(string details)
        {
            return feedRepo.Get(details);
        }
        public int Insert(Feedback feed)
        {
            return feedRepo.Insert(feed);
        }
    }
}
