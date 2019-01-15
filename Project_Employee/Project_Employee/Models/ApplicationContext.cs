using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Employee.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
            public ApplicationContext() : base("IdentityDb") { }

            public static ApplicationContext Create()
            {
                return new ApplicationContext();
            }
        
    }
}