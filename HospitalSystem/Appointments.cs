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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userAppointment = textBox1.Text;
            var dateForAppointment = maskedTextBox1.Text;
            var doctorForAppointment = comboBox1.Text;

            var patientAccount = new Appointments();
            patientAccount.ShowDialog();
            this.Close();
        }
    }
}
