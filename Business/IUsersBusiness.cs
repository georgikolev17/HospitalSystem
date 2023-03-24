using Data.Models;

namespace Business
{
    public interface IUsersBusiness
    {
        public void RegisterNewDoctor(string email, string username, string password, string name, string doctorType, string phone, string gender, int age);
        public void RegisterNewPatient(string email, string username, string password, string name, int age, string egn, string phone, string bloodType, string address, string gender);

        public BaseUser LoginUser(string email, string password);

        public BaseUser? GetUserByEmail(string email);

        public BaseUser? GetUserById(int userId);

        public Patient? FindPatientByName(string name);

        public Doctor? FindDoctorByName(string name);
    }
}
