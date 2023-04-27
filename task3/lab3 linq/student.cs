using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lab3_linq
{
    class student
    {
        public int ID { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        ///department relation////
        [ForeignKey("department")]
        public int Dept_ID { get; set; }

        public department department { get; set; }
        public List<Stud_Course> stud_Courses { get; set; }

        ///self relation////
        [ForeignKey("student1")]
        public int st_Super { get; set; }
        public student student1 { get; set; }
    }

}
