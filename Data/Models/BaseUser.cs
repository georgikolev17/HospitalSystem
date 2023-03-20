using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public abstract class BaseUser
    {
        public BaseUser()
        {
        }
        protected BaseUser(string email, string username, string password)
        {
            this.Email=email;
            this.Username=username;
            this.Password=password;
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
