using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_final
{
    public partial class Form2 : Form
    {
        Company_SDEntities Context;
       
        public Form2()
        {
            InitializeComponent();
            Context = new Company_SDEntities();
            dataGridView1.DataSource = Context.Departments.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var dep = new Department
            {
                Dname = textBox3.Text,
                
                Dnum = (int)numericUpDown1.Value ,
               
            };


            Context.Departments.Add(dep);
            Context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Context.Departments.ToList();
        }
    }
}
