using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_register
{
    public partial class Pet_Register : Form
    {
        public Pet_Register()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Register_Details register_details = new Register_Details();
            register_details.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 report = new Form3();
            report.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 report1 = new Form3();
            report1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.Show();
        }

        private void Pet_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
