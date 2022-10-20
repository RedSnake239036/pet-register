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
    }
}
