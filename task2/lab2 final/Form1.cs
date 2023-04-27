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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        int count = 49;
        int SSN;
        Company_SDEntities Context;
       
        public Form1()
        {
            InitializeComponent();
            
            Context = new Company_SDEntities();
            dataGridView1.DataSource = Context.Employees.ToList();
            comboBox1.DataSource = Context.Departments.ToList();
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Dnum";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var emp = new Employee
            {
                Fname = textBox1.Text,
                Lname = textBox2.Text,
                Salary = (int)numericUpDown1.Value,
                Dno = (int)comboBox1.SelectedValue,
                SSN = count ++,
            };


            Context.Employees.Add(emp);
            Context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Context.Employees.ToList();
           
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value;

            SSN = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = Context.Employees.Where(em => em.SSN == SSN).FirstOrDefault();
            query.Fname = textBox1.Text;
            query.Lname = textBox2.Text;
            query.Salary = (int)numericUpDown1.Value;
            query.Dno = (int)comboBox1.SelectedValue;

            Context.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Context.Employees.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
