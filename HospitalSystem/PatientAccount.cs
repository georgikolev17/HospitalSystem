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
    public partial class PatientAccount : Form
    {
        private Patient patient;

        public PatientAccount(Patient patient)
        {
            InitializeComponent();
            this.patient=patient;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label10.Text = patient.Name;
            label12.Text = patient.Address;
            label13.Text = patient.Email;
            label14.Text = patient.PhoneNumber;
            label15.Text = patient.Age.ToString();
            label16.Text = patient.Gender;
            label17.Text = patient.BloodType;
            label18.Text = patient.EGN;
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var appointment = new Appointments(patient);
            appointment.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Dispose();
            loginForm.ShowDialog();
        }
    }
}
