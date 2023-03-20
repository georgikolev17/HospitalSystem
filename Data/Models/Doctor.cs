using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Doctor
    {
        public Doctor(int id, string name, string doctorType)
        {
            Id=id;
            Name=name;
            DoctorType=doctorType;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string DoctorType { get; set; }
    }
}
