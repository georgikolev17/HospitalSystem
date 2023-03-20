using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Patient : BaseUser
    {
        public Patient()
        {
        }
        public Patient(string email, string username, string password, string name, int age, string egn, int? roomId)
            : base(email, username, password)
        {
            this.Name = name;
            this.Age = age;
            this.EGN = egn;
            this.RoomId = roomId;
            this.Diagnoses = new List<Diagnose>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string EGN { get; set; }

        public int? RoomId { get; set; }
        public virtual Room? Room { get; set; }

        public virtual ICollection<Diagnose> Diagnoses { get; set; }
    }
}
