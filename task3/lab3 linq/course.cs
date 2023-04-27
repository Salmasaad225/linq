using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_linq
{
    class course
    {
        public int ID { get; set; }
        public string Crs_name { get; set; }

        public int Crs_Duration { get; set; }

        public List<Stud_Course> stud_Courses { get; set; }
    }
}
