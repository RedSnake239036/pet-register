using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pet_register
{
    public partial class Register_Details : Form
    {
        public Register_Details()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button1.Visible = false;
            (textBox1.Enabled, textBox2.Enabled, textBox3.Enabled, textBox4.Enabled,
                textBox5.Enabled, textBox6.Enabled, textBox7.Enabled, button3.Visible, button4.Visible) = 
                (true, true, true, true, true, true, true, true, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button5.Visible = false;

            (textBox1.Enabled, textBox2.Enabled, textBox3.Enabled, textBox4.Enabled,
            textBox5.Enabled, textBox6.Enabled, textBox7.Enabled, button3.Visible, button4.Visible) =
                (false, false, false, false, false, false, false, false, false);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2();
            report.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PetOwners owners = new PetOwners();
            owners.Show();
        }

        private void Register_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
