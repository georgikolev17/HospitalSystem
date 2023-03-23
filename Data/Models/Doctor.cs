using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Doctor : BaseUser
    {
        public Doctor()
        {
        }
        public Doctor(string email, string username, string password, string name, string doctorType, string phone)
            : base(email, username, password, phone, name)
        {
            DoctorType = doctorType;
            this.MedicalReviews = new List<MedicalReview>();
        }

        public int DoctorId { get; set; }

        [Required]
        public string DoctorType { get; set; }

        public virtual ICollection<MedicalReview> MedicalReviews { get; set; }
    }
}
