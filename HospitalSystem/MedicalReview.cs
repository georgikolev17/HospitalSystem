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
    public partial class MedicalReview : Form
    {
        private readonly Data.Models.MedicalReview medicalReview;
        private readonly IRoomBusiness roomBusiness;
        private readonly IMedicalReviewsBusiness medicalReviewsBusiness;


        public MedicalReview(Data.Models.MedicalReview medicalReview)
        {
            InitializeComponent();
            this.medicalReview=medicalReview;
            this.roomBusiness = new RoomBusiness();
            this.medicalReviewsBusiness = new MedicalReviewBusiness();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (this.medicalReview.Diagnose != null)
            {
                this.textBox1.Text = this.medicalReview.Diagnose.IllnessDescription ?? string.Empty;
                this.textBox2.Text = this.medicalReview.Diagnose.Prescription ?? string.Empty;
            }
            var emptyRooms = this.roomBusiness.GetAllFreeRooms(this.medicalReview.PatientId);

            foreach (var room in emptyRooms)
            {
                this.comboBox1.Items.Add(room.RoomId.ToString());
            }
            var roomNumber = this.roomBusiness.GetPatientRoom(this.medicalReview.PatientId);
            if (roomNumber != null)
            {
                var a = comboBox1.FindStringExact(roomNumber.ToString());
                comboBox1.SelectedIndex = comboBox1.FindStringExact(roomNumber.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var diagnose = this.textBox1.Text;
            var prescription = this.textBox2.Text;
            var room = int.Parse(this.comboBox1.SelectedItem?.ToString() ?? "-1");

            if (room != -1)
            {
                this.roomBusiness.GivePatientRoom(medicalReview.Patient.PatientId, room);
            }
            this.medicalReviewsBusiness.EditMedicalReview(medicalReview.MedicalReviewId, diagnose, prescription, medicalReview.Patient.PatientId);
            this.Dispose();
        }
    }
}
