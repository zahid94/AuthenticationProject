using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthenticationProject.Models
{
    public class AuthenticationDbContext:DbContext
    {
        public AuthenticationDbContext():base("Db")
        {

        }
        public DbSet<User> users { get; set; }
    }

}