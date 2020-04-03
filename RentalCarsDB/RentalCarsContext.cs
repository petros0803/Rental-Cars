using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB
{
    public class RentalCarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }

        public RentalCarsContext() : base("name=RentalCarsContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasOptional(c => c.Person).WithRequired(p => p.Car);
        }
    }
}
