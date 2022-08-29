using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace identity_template.Identity
{
    public class ApplicationDbContext: IdentityDbContext <ApplicationUser>

    {
        public ApplicationDbContext() : base("default connection")
        {

        }
    }
}