using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PaymentService
    {
        PaymentRepository pRepo;
        public PaymentService()
        {
            pRepo = new PaymentRepository();
        }

        public List<Payment> GetAllPayment()
        {
            return pRepo.GetAll();
        }
        //public Food GetById(int id)
        //{
        //    return foodRepo.Get(id);
        //}
        //public Food GetByName(string name)
        //{
        //    return foodRepo.Get(name);
        //}
        public int Insert(Payment cat)
        {
            return pRepo.Insert(cat);
        }
        //public int update(Food cat)
        //{
        //    return foodRepo.Update(cat);
        //}
        //public int delete(int id)
        //{
        //    return foodRepo.delete(id);
        //}
    }
}
