using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Aspects;
using Sample.Validation;

namespace Sample.Commands
{
    public class RegisterUser : ICommand<bool>, ICurrentUser
    {
        public string CurrentUser { get; private set; }
        public string NewUserName { get; private set; }

        [Required]
        public string Password { get; private set; }

        public RegisterUser(string currentUser, string newUserName, string password)
        {
            this.CurrentUser = currentUser;
            this.NewUserName = newUserName;
            this.Password = password;
        }
    }
}
