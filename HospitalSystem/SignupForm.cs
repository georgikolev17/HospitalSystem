using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Email")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Email";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This takes up memory, needs to be fixed (maybe) :)
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "First Name")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "First Name";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Last Name")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e) // Placeholder
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Last Name";
            }
        }
    }
}
