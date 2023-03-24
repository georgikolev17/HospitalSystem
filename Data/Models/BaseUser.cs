using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public abstract class BaseUser
    {
        public BaseUser()
        {
        }
        protected BaseUser(string email, string username, string password, string phoneNumber, string name)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Name = name;
        }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

    }
}
