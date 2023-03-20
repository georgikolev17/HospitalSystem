using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Doctor : BaseUser
    {
        public Doctor()
        {
        }
        public Doctor(string email, string username, string password, string name, string doctorType)
            : base(email, username, password)
        {
            Name=name;
            DoctorType=doctorType;
            this.MedicalReviews = new List<MedicalReview>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string DoctorType { get; set; }

        public virtual ICollection<MedicalReview> MedicalReviews { get; set; }
    }
}
