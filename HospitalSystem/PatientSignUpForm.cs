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
    public partial class PatientSignUpForm : Form
    {
        public PatientSignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patientName = textBox1.Text;
            var address = textBox2.Text;
            var patientEmail = textBox3.Text;
            var patientPhone = maskedTextBox1.Text;
            var patientAge = textBox4.Text;
            var patientGender = comboBox1.Text;
            var patientBloodType = comboBox2.Text;
            var egn = maskedTextBox2.Text;
            var patientUsername = textBox5.Text;
            var patientPassword = textBox6.Text;
        }
    }
}
