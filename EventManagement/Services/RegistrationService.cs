using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegistrationService
    {
        RegistrationRepository regRepo;
        public RegistrationService()
        {
            regRepo = new RegistrationRepository();
        }
        public int UserRegistration(string name, string gender, string email, string phone, string address, string username, string password, int type)
        {
            return regRepo.Register(name, gender, email, phone, address, username, password, type);
        }
        public User GetUserInfo(Login ln)
        {
            return regRepo.GetUser(ln);
        }
    }
}
