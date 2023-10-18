using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_ASG2.DTL
{
    internal class Show
    {
        public int ShowID { get; set; }
        public int RoomID { get; set; }
        public int FilmID { get; set; }
        public DateTime ShowDate { get; set; }
        public decimal? Price { get; set; }
        public bool? Status { get; set; }
        public int? Slot { get; set; }
    }
}
