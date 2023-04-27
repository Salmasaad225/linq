using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_linq
{
    class department
    {
        public int ID { get; set; }
        public string DeptName { get; set; }

        public string DeptDesc { get; set; }
        public string Location { get; set; }
        public int DeptManager { get; set; }
        public DateTime? hireDate { get; set; }

        public List<student> students { get; set; }
    }
}
