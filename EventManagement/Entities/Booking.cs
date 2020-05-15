using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string Vanue{ get; set; }
        public string Date { get; set; }
        public int NoOfGuest { get; set; }
        public int Status { get; set; }
        public string SelectedFood { get; set; }
        public string SelectedEquipment { get; set; }
        public double Cost { get; set; }

    }
}
