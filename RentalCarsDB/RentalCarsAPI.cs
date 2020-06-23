using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB
{
    public static class RentalCarsAPI
    {
        public static async Task SaveUserAsync(User user)
        {
            using (var context = new RentalCarsContext())
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }
        public static async Task<User> GetUserByUsernameAsync(string username)
        {
            using (var context = new RentalCarsContext())
            {
                return await context.Users.Where(u => u.Username == username).FirstOrDefaultAsync();
            }
        }
        public static async Task SaveCarAsync(Car car)
        {
            using (var context = new RentalCarsContext())
            {
                context.Cars.Add(car);
                await context.SaveChangesAsync();
            }
        }

        public static async Task SavePersonAsync(Person person)
        {
            using (var context = new RentalCarsContext())
            {
                context.People.Add(person);
                await context.SaveChangesAsync();
            }
        }

        public static async Task<bool> PersonAlreadyExist(Person person)
        {
            using (var context = new RentalCarsContext())
            {
                return await context.People.Where(p => p.PersonId == person.PersonId).FirstOrDefaultAsync() != null;
            }
        }

        public static async Task<List<Car>> GetCarsAsync()
        {
            using (var context = new RentalCarsContext())
            {
                return await context.Cars.ToListAsync();
            }
        }

        public static async Task<bool> CarAlreadyExist(Car car)
        {
            using (var context = new RentalCarsContext())
            {
                return await context.Cars.Where(c => c.CarPlate == car.CarPlate).FirstOrDefaultAsync() != null;
            }
        }

        public static async Task RentToPersonAsync(Guid carId, Person person)
        {
            using (var context = new RentalCarsContext())
            {
                var result = context.Cars.Where(c => c.CarId == carId).FirstOrDefault();
                if (result != null)
                {
                    result.Person = person;
                    result.Rented = true;
                    
                    await context.SaveChangesAsync();
                }
            }
        }

        public static async Task FreeCar(Guid carId)
        {
            using (var context = new RentalCarsContext())
            {
                var result = context.Cars.Where(c => c.CarId == carId).FirstOrDefault();
                var personResult = context.People.Where(p => p.Car.CarId == carId).FirstOrDefault();

                if (result != null)
                {
                    result.Person = null;
                    result.Rented = false;
                    //context.People.Remove(result.Person);
                    personResult.Car = null;
                    await context.SaveChangesAsync();
                }
            }
        }

        public static async Task<Person> GetPersonByCardId(Guid carId)
        {
            using (var context = new RentalCarsContext())
            {
                //var car = await context.Cars.Where(c => c.CarId == carId).FirstOrDefaultAsync();
                return await context.People.Where(p => p.Car.CarId == carId).FirstOrDefaultAsync();
            }
        }

        public static async Task<Car> GetCarById(Guid carId)
        {
            using (var context = new RentalCarsContext())
            {
                return await context.Cars.Where(c => c.CarId == carId).FirstOrDefaultAsync();
            }
        }
        public static async Task<bool> LogInAsync(User user)
        {
            using (var context = new RentalCarsContext())
            {
                var userFromDB = await context.Users.Where(u => u.Username == user.Username 
                && u.Password == user.Password).FirstOrDefaultAsync();
                return userFromDB != null;
            }
        }
    }
}
