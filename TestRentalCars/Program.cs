using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRentalCars
{
    class Program
    { 
        static void Main(string[] args)
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                context.Users.Add(User.Create("admin", "admin"));
                context.SaveChanges();
                foreach(var x in context.Users)
                {
                    Console.WriteLine(x.Username);
                }
            }   
        }
        
    }

}
