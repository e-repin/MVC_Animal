using DataAccess.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ContextAnimalHomes : IdentityDbContext<Employee>
    {
        public ContextAnimalHomes(DbConnection connection) : base(connection, false)// : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Home> Homes { get; set; }

        //public DbSet<Employee> Employees { get; set; }
    }
}
