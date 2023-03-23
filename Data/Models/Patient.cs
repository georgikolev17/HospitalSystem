using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Patient : BaseUser
    {
        public Patient()
        {
        }
        public Patient(string email, string username, string password, string name, int age, string egn, string phone, string bloodType, string address)
            : base(email, username, password, phone, name)
        {
            this.Age = age;
            this.EGN = egn;
            this.Diagnoses = new List<Diagnose>();
            this.BloodType=bloodType;
            this.Address=address;
        }

        public int Id { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string EGN { get; set; }

        public string BloodType { get; set; }

        public string Address { get; set; }

        public int? RoomId { get; set; }
        public virtual Room? Room { get; set; }

        public virtual ICollection<Diagnose> Diagnoses { get; set; }
    }
}
