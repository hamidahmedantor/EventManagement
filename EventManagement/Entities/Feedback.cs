using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Feedback_Details { get; set; }
        public string Event_Type { get; set; }
        public string Bid { get; set; }
    }
}
