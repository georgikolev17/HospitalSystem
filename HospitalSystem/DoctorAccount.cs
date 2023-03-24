﻿using Business;
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
        private readonly IMedicalReviewsBusiness medicalReviewsBusiness;
        private readonly IUsersBusiness usersBusiness;

        public DoctorAccount(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            this.medicalReviewsBusiness = new MedicalReviewBusiness();
            this.usersBusiness = new UsersBusiness();
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

            var medicalReviews = this.medicalReviewsBusiness.GetUpcomingMedicalReviewsForDoctor(doctor.Email);

            foreach (var review in medicalReviews)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                row.Cells[0].Value = review.Patient.Name;
                row.Cells[1].Value = review.Date.ToString("dd/MM/yyyy HH:mm");
                row.Cells[2].Value = "Детайли";
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var review = this.medicalReviewsBusiness.FindMedicalReview(doctor.DoctorId, this.usersBusiness.FindPatientByName(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex-2].Value.ToString()).PatientId);

                var mdeicalReviewForm = new MedicalReview(review);
                mdeicalReviewForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Dispose();
            loginForm.ShowDialog();
        }
    }
}
