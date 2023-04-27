using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace lab3_linq
{
    class Stud_Course
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("course")]
        public int Crs_ID { get; set; }
        public course course { get; set; }



        [Key]
        [Column(Order = 2)]
        [ForeignKey("student")]
        public int Stud_ID { get; set; }
        public student student { get; set; }

        public int Grade { get; set; }
    }
}
