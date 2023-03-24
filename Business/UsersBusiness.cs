using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UsersBusiness : IUsersBusiness
    {
        public UsersBusiness()
        {
        }

        public Doctor? FindDoctorByName(string name)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            return dbContext.Doctors.FirstOrDefault(x => x.Name == name);
        }

        public Patient? FindPatientByName(string name)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            return dbContext.Patients.FirstOrDefault(x => x.Name == name);
        }

        public ICollection<string> GetAllDoctorNames()
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Doctors
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();
        }

        public BaseUser? GetUserByEmail(string email)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var doctor = dbContext.Doctors.FirstOrDefault(x =>  x.Email == email);
            var patient = dbContext.Patients.FirstOrDefault(x =>  x.Email == email);

            if (doctor == null && patient == null)
            {
                return null;
            }
            else if (doctor != null)
            {
                return doctor;
            }
            return patient;
        }

        public BaseUser? GetUserById(int userId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var doctor = dbContext.Doctors.FirstOrDefault(x => x.DoctorId == userId);
            var patient = dbContext.Patients.FirstOrDefault(x => x.PatientId == userId);

            if (doctor == null && patient == null)
            {
                return null;
            }
            else if (doctor != null)
            {
                return doctor;
            }
            return patient;
        }

        // Returns the logged in user if the login process is successfull, and throws an error if not
        public BaseUser LoginUser(string email, string password)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            var doctor = dbContext.Doctors.FirstOrDefault(x => x.Email == email && x.Password == password);
            var patient = dbContext.Patients.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (doctor == null && patient == null)
            {
                throw new Exception("User with these email and password does not exists!");
            }
            else if (doctor != null)
            {
                return doctor;
            }
            return patient;
        }

        public void RegisterNewDoctor(string email, string username, string password, string name, string doctorType, string phone, string gender, int age)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            if (GetUserByEmail(email) != null)
            {
                throw new Exception("User with such email already exists!");
            }
            dbContext.Doctors.Add(new Doctor(email, username, password, name, doctorType, phone, gender, age));
            dbContext.SaveChanges();
        }

        public void RegisterNewPatient(string email, string username, string password, string name, int age, string egn, string phone, string bloodType, string address, string gender)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            if (GetUserByEmail(email) != null)
            {
                throw new Exception("User with such email already exists!");
            }
            dbContext.Patients.Add(new Patient(email, username, password, name, age, egn, phone, bloodType, address, gender));
            dbContext.SaveChanges();
        }
    }
}
