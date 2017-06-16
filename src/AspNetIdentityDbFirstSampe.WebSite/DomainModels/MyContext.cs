using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentityDbFirstSampe.WebSite.DomainModels
{
    public partial class MyContext
        : IdentityDbContext<AspNetUser, AspNetRole, string, AspNetUserLogin, AspNetUserRole, AspNetUserClaim>
    {
        public static MyContext Create()
        {
            return new MyContext();
        }
    }
}






