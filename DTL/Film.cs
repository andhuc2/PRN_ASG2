﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_ASG2.DTL
{
    public class Film
    {
        public int FilmID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string CountryCode { get; set; }
        public string FilmUrl { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }

}
