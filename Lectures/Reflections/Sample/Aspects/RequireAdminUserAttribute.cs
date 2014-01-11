using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Aspects
{
    public class RequireAdminUserAttribute : HandlerAspectAttribute
    {
        public override void BeforeHandle(object command)
        {
            var currentUser = command as ICurrentUser;

            if (currentUser != null && currentUser.CurrentUser != "admin")
            {
                throw new SecurityException("Must be admin");
            }
        }
    }
}
