using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookingService
    {
        BookingRepository bRepo;
        public BookingService()
        {
            bRepo = new BookingRepository();
        }
        public List<Booking> GetAllBooking()
        {
            return bRepo.GetAll();
        }
        public int Insert(Booking cat)
        {
            return bRepo.Insert(cat);
        }
        public Booking GetById(int id)
        {
            return bRepo.Get(id);
        }
        public int update(Booking cat)
        {
            return bRepo.Update(cat);
        }
        public int delete(int id)
        {
            return bRepo.delete(id);
        }
        public int update1(int id, double pay)
        {
            return bRepo.Update1(id, pay);
        }
        public List<Booking> GetAllBookings()
        {
            return bRepo.GetAlls();
        }
    }
}
