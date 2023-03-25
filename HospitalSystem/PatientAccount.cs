using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class PatientAccount : Form
    {
        private Patient patient;
        private readonly IMedicalReviewsBusiness medicalReviewsBusiness;

        public PatientAccount(Patient patient)
        {
            InitializeComponent();
            this.patient=patient;
            this.medicalReviewsBusiness = new MedicalReviewBusiness();
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

            var medicalReviews = this.medicalReviewsBusiness.GetPastMedicalReviewsForPatient(patient.PatientId);

            foreach (var review in medicalReviews)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView3.Rows[0].Clone();

                row.Cells[0].Value = review.Diagnose?.IllnessDescription ?? "N/A";
                row.Cells[1].Value = review.Date.ToString("dd/MM/yyyy HH:mm");
                row.Cells[2].Value = review.Doctor.Name;
                dataGridView3.Rows.Add(row);
            }


            var upcomingReviews = this.medicalReviewsBusiness.GetUpcomingMedicalReviewsForPatient(patient.PatientId);
            foreach (var review in upcomingReviews)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                row.Cells[0].Value = review.Date.ToString("dd/MM/yyyy HH:mm");
                row.Cells[1].Value = review.Doctor.Name;
                row.Cells[2].Value = review.Doctor.DoctorType;
                dataGridView1.Rows.Add(row);
            }

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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var patientAccount = new PatientAccount(patient);
            patientAccount.ShowDialog();
        }
    }
}
