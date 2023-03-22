using Data.Models;

namespace Business
{
    public interface IUsersBusiness
    {
        public void RegisterNewDoctor(string email, string username, string password, string name, string doctorType, string phone);

        public void RegisterNewPatient(string email, string username, string password, string name, int age, string egn, string phone);

        public void LoginUser(string email, string password);

        public BaseUser? GetUserByEmail(string email);

        public BaseUser GetUserById(int userId);
    }
}
