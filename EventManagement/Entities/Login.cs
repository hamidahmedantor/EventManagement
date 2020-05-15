using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Login
    {
        public int Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public int UserType { set; get; }
        public int UId { set; get; }
    }
}
