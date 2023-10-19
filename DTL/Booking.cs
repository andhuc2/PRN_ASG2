using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_ASG2.DTL
{
    internal class Booking
    {
        public int BookingID { get; set; }
        public int ShowID { get; set; }
        public string Name { get; set; }
        public string SeatStatus { get; set; }
        public decimal Amount { get; set; }
    }
}
