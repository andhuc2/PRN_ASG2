using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_ASG2.DTL
{
    internal class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
