using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace lab3_linq
{
    class Context : DbContext
    {
        public Context() : base(@"Data Source=DESKTOP-P73CSRJ\SQLEXPRESS;Initial Catalog=itii;Integrated Security=True")
        { }

        public DbSet<department> Departments { get; set; }
        public DbSet<student> Students { get; set; }
        public DbSet<course> Courses { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
