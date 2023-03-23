using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class MedicalReview
    {
        public MedicalReview()
        {
        }
        public MedicalReview(int patientId, int doctorId, DateTime date)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            Date = date;
        }

        public int MedicalReviewId { get; set; }

        [Required]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int? DiagnoseId { get; set; }
        public virtual Diagnose Diagnose { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
