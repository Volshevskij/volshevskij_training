using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Task_17.Models
{
    public class UserContext : DbContext
    {

        public UserContext(): base("UserContext") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UserContext, Task_17.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users
        {
            get;
            set;
        }

        public void Reset()
        {
            this.Dispose();
        }
    }
}