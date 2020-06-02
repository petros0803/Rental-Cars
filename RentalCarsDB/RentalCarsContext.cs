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
        {
            Database.CreateIfNotExists();

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
               .HasOptional(s => s.Person)
               .WithRequired(p => p.Car);
        }
    }
}
