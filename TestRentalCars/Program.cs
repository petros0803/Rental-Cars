using RentalCarsDB;
using RentalCarsDB.Enums;
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
        static async Task Main(string[] args)
        {
            var adminUser = await RentalCarsAPI.GetUserByUsernameAsync("admin");
            if (await RentalCarsAPI.GetUserByUsernameAsync("admin") == null)
            {
                await RentalCarsAPI.SaveUserAsync(User.Create("admin", "admin"));
            }
            else
            {
                Console.WriteLine("{0}, {1}", adminUser.Username, adminUser.Password);
            }

            Car mertzan = Car.Create("Mercedes", "12731273121", 6.2, DateTime.Now, FuelType.Diesel, DateTime.Now);

            if (!await RentalCarsAPI.CarAlreadyExist(mertzan))
                await RentalCarsAPI.SaveCarAsync(mertzan);

            var cars = await RentalCarsAPI.GetCarsAsync();

            await RentalCarsAPI.RentToPersonAsync(cars[0].CarId, Person.Create("TEST1", "TEST2", DateTime.Now, DateTime.Now.AddDays(1), "TEST3"));
        }
    }
}
