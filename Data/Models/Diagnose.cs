using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Diagnose
    {
        public Diagnose()
        {
        }
        public Diagnose(int patientId, string illnessDescription, string prescription)
        {
            this.PatientId = patientId;
            this.IllnessDescription = illnessDescription;
            this.Prescription = prescription;
        }

        public int DiagnoseId { get; set; }

        [Required]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public string IllnessDescription { get; set; }

        public string Prescription { get; set; }
    }
}