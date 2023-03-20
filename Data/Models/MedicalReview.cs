using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MedicalReview
    {
        public MedicalReview()
        {
        }
        public MedicalReview(int patientId, int doctorId, int diagnoseId, DateTime date)
        {
            PatientId=patientId;
            DoctorId=doctorId;
            DiagnoseId=diagnoseId;
            Date=date;
        }

        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public int DiagnoseId { get; set; }
        public virtual Diagnose Diagnose { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
