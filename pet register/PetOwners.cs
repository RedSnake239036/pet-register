using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_register
{
    public partial class PetOwners : Form
    {
        public PetOwners()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pet_Register register = new Pet_Register();
            register.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 report1 = new Form3();
            report1.Show();
        }

        private void PetOwners_Load(object sender, EventArgs e)
        {

        }
    }
}
