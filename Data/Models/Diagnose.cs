using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Diagnose
    {
        public Diagnose()
        {
        }
        public Diagnose(int patientId, string illnessDescription)
        {
            this.PatientId = patientId;
            this.IllnessDescription = illnessDescription;
        }

        public int DiagnoseId { get; set; }

        [Required]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public string IllnessDescription { get; set; }
    }
}