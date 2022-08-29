using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace identity_template.Identity
{
    public class ApplicationUserManager: UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore <ApplicationUser> store): base(store)
        {

        }
    }
}