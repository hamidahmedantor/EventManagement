using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService
    {
        CredentialRepository credRepo;
        public LoginService()
        {
            credRepo = new CredentialRepository();
        }

        public Login LoginValidation(Login ln)
        {
            return credRepo.Validation(ln);
        }
    }
}
