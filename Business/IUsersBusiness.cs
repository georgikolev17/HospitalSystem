using Data.Models;

namespace Business
{
    public interface IUsersBusiness
    {
        public void RegisterNewDoctor(string email, string username, string password, string name, string doctorType, string phone)
        {
            using Data.ApplicationDbContext context = new Data.ApplicationDbContext();


            context.Doctors.Add(new Doctor
            {
                Email = email,
                Username = username,
                Password = password,
                Name = name,
                DoctorType = doctorType,
                PhoneNumber = phone

            });
            context.SaveChanges();
        }

        public void RegisterNewPatient(string email, string username, string password, string name, int age, string egn, string phone)
        {
            using Data.ApplicationDbContext context = new Data.ApplicationDbContext();

            context.Patients.Add(new Patient
            {
                Email = email,
                Username = username,
                Password = password,
                Name = name,
                Age = age,
                EGN = egn,
                PhoneNumber = phone
            });
        }

        public void LoginUser(string email, string password);

        public BaseUser? GetUserByEmail(string email);


        public BaseUser GetUserById(int userId);
    }
}
