using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Doctor : BaseUser
    {
        public Doctor()
        {
        }
        public Doctor(string email, string username, string password, string name, string doctorType, string phone, string gender, int age)
            : base(email, username, password, phone, name, UserType.Doctor)
        {
            DoctorType = doctorType;
            this.MedicalReviews = new List<MedicalReview>();
            this.Gender=gender;
            this.Age=age;
        }

        public int DoctorId { get; set; }

        [Required]
        public string DoctorType { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public virtual ICollection<MedicalReview> MedicalReviews { get; set; }
    }
}
