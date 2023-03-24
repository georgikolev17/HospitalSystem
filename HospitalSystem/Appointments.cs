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

namespace HospitalSystem
{
    public partial class Appointments : Form
    {
        private readonly IUsersBusiness usersBusiness;
        private readonly IMedicalReviewsBusiness medicalReviewsBusiness;
        private readonly Patient patient;

        public Appointments(Patient patient)
        {
            InitializeComponent();
            this.usersBusiness = new UsersBusiness();
            this.medicalReviewsBusiness = new MedicalReviewBusiness();
            this.patient=patient;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (var name in this.usersBusiness.GetAllDoctorNames())
            {
                comboBox1.Items.Add(name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dateForAppointment = DateTime.ParseExact(maskedTextBox1.Text, "dd.MM.yyyy HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture); ;
            var doctorForAppointment = comboBox1.Text;
            if (dateForAppointment != null  && doctorForAppointment != null)
            {
                try
                {
                    this.medicalReviewsBusiness.BookMedicalReview(this.patient.PatientId, usersBusiness.FindDoctorByName(doctorForAppointment).DoctorId, dateForAppointment);
                    this.Dispose();
                }
                catch (Exception ex)
                {
                }
                
            }
            this.Dispose();
        }
    }
}
