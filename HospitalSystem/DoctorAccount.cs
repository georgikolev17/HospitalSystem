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

namespace HospitalSystem
{
    public partial class DoctorAccount : Form
    {
        private Doctor doctor;

        public DoctorAccount(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label8.Text = doctor.Name;
            label9.Text = doctor.Email;
            label10.Text = doctor.PhoneNumber;
            label12.Text = doctor.Age.ToString();
            label13.Text = doctor.Gender;
            label14.Text = doctor.DoctorType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginForm();
            loginPage.Show();
            this.Close();
        }
    }
}
