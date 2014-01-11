using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Aspects;
using Sample.Commands;

namespace Sample.CommandHandlers
{
    [RequireAdminUser]
    [ValidateCommand]
    public class RegisterUserHandler
    {
        public bool Handle(RegisterUser cmd)
        {
            return true;
        }
    }
}
