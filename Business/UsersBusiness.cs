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
        private ApplicationDbContext dbContext;

        public UsersBusiness()
        {
            this.dbContext = new ApplicationDbContext();
        }

        public BaseUser? GetUserByEmail(string email)
        {
            var doctor = this.dbContext.Doctors.FirstOrDefault(x =>  x.Email == email);
            var patient = this.dbContext.Patients.FirstOrDefault(x =>  x.Email == email);

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
            var doctor = this.dbContext.Doctors.FirstOrDefault(x => x.Id == userId);
            var patient = this.dbContext.Patients.FirstOrDefault(x => x.Id == userId);

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
            var doctor = this.dbContext.Doctors.FirstOrDefault(x => x.Email == email && x.Password == password);
            var patient = this.dbContext.Patients.FirstOrDefault(x => x.Email == email && x.Password == password);

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

        public void RegisterNewDoctor(string email, string username, string password, string name, string doctorType, string phone)
        {
            if(GetUserByEmail(email) != null)
            {
                throw new Exception("User with such email already exists!");
            }
            this.dbContext.Doctors.Add(new Doctor(email, username, password, name, doctorType, phone));
            this.dbContext.SaveChanges();
        }

        public void RegisterNewPatient(string email, string username, string password, string name, int age, string egn, string phone, string bloodType, string address)
        {
            if (GetUserByEmail(email) != null)
            {
                throw new Exception("User with such email already exists!");
            }
            this.dbContext.Patients.Add(new Patient(email, username, password, name, age, egn, phone, bloodType, address));
            this.dbContext.SaveChanges();
        }
    }
}
