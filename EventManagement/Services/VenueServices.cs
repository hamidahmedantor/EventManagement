using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VenueServices
    {
        VenueRepository vanRepo;
        public VenueServices()
        {
            vanRepo = new VenueRepository();
        }

        public List<Venue> GetAllVenues()
        {
            return vanRepo.GetAll();
        }
        public Venue GetById(int id)
        {
            return vanRepo.Get(id);
        }
        public Venue GetByName(string name)
        {
            return vanRepo.Get(name);
        }
        public int Insert(Venue cat)
        {
            return vanRepo.Insert(cat);
        }
        public int update(Venue cat)
        {
            return vanRepo.Update(cat);
        }
        public int delete(int id)
        {
            return vanRepo.delete(id);
        }
    }
}
