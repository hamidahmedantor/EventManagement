using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EquipmentService
    {
        EquipmentRepository ecuRepo;
        public EquipmentService()
        {
            ecuRepo = new EquipmentRepository();
        }

        public List<Equipment> GetAllEquipment()
        {
            return ecuRepo.GetAll();
        }
        public Equipment GetById(int id)
        {
            return ecuRepo.Get(id);
        }
        public Equipment GetByName(string name)
        {
            return ecuRepo.Get(name);
        }
        public int Insert(Equipment cat)
        {
            return ecuRepo.Insert(cat);
        }
        public int update(Equipment cat)
        {
            return ecuRepo.Update(cat);
        }
        public int delete(int id)
        {
            return ecuRepo.delete(id);
        }
    }
}

