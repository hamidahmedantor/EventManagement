using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public int Pid { get; set; }
        public int CardNo { get; set; }
        public int CvvNo { get; set; }
        public String NameOnCard { get; set; }
        public String ExpDate { get; set; }
        public int Bid { get; set; }
        public double Payments { get; set; }



    }
}
