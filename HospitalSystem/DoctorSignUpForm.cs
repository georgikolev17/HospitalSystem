using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalSystem
{
    public partial class DoctorSignUpForm : Form
    {
        private readonly IUsersBusiness usersBusiness;

        public DoctorSignUpForm()
        {
            InitializeComponent();
            this.usersBusiness= new UsersBusiness();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var doctortName = textBox1.Text;
            var doctorEmail = textBox2.Text;
            var doctorPhone = maskedTextBox1.Text;
            var doctorAge = textBox3.Text;
            var doctorGender = comboBox1.Text;
            var speciality = textBox4.Text;
            var doctorUsername = textBox5.Text;
            var doctorPassword = textBox6.Text;

            try
            {
                this.usersBusiness.RegisterNewDoctor(doctorEmail, doctorUsername, doctorPassword, doctortName, speciality, doctorPhone);
                var doctor = this.usersBusiness.LoginUser(doctorEmail, doctorPassword);
                var doctorAccountPage = new DoctorAccount(doctor as Doctor);
                doctorAccountPage.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
