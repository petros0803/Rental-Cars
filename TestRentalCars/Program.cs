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
                //context.Users.Add(User.Create("admin", "admin"));

                User user = context.Users.Where(u => u.Username == "admin").FirstOrDefault();
                context.Users.Remove(user);

                context.SaveChanges();
                foreach(var x in context.Users)
                {
                    Console.WriteLine(x.Username);
                }
            }   
        }
        
    }

}
