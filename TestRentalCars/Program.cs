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

            Car mercedes = Car.Create("Mercedes", "BT 98 BGD", 6.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw = Car.Create("BMW", "BT 98 MRA", 1.6, DateTime.Now, FuelType.Electric, DateTime.Now);
            Car mercedes1 = Car.Create("Mercedes", "BT 01 KID", 2.0, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw1 = Car.Create("BMW", "BT 72 DCX", 1.9, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car mercedes2 = Car.Create("Mercedes", "BT 02 GYU", 3.0, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw2 = Car.Create("BMW", "BT 92 LKU", 5.2, DateTime.Now, FuelType.Bio_Diesel, DateTime.Now);
            Car mercedes3 = Car.Create("Mercedes", "BT 21 VCF", 6.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw3 = Car.Create("BMW", "BT 81 BOS", 5.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car opel = Car.Create("OPEL", "SV 07 CMZ", 8.2, DateTime.Now, FuelType.Gasoline, DateTime.Now);
            Car alfaRomeo = Car.Create("Alfa Romeo", "IS 32 FOM", 2.9, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car audi = Car.Create("AUDI", "IS 92 KSM", 3.0, DateTime.Now, FuelType.Electric, DateTime.Now);
            Car mercedes4 = Car.Create("Mercedes", "BT 53 VTM", 2.0, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw4 = Car.Create("BMW", "B 88 AMN ", 5.0, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car audi1 = Car.Create("AUDI", "B 666 BMW", 4.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw5 = Car.Create("BMW", "SV 51 SAT", 5.2, DateTime.Now, FuelType.Bio_Diesel, DateTime.Now);
            Car opel1 = Car.Create("OPEL", "BT 66 CMZ", 6.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car bmw6 = Car.Create("BMW", "BT 81 BOS", 5.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car opel2 = Car.Create("OPEL", "SV 07 CMZ", 8.2, DateTime.Now, FuelType.Gasoline, DateTime.Now);
            Car passat = Car.Create("VOLKSWAGEN", "BT 98 RZV", 1.9, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car fiat = Car.Create("FIAT", "SV 83 SHJ", 5.2, DateTime.Now, FuelType.Diesel, DateTime.Now);
            Car chevrolet = Car.Create("CHEVROLET", "SV 21 KJH", 8.2, DateTime.Now, FuelType.Gasoline, DateTime.Now);

            if (!await RentalCarsAPI.CarAlreadyExist(mercedes))
                await RentalCarsAPI.SaveCarAsync(mercedes);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw))
                await RentalCarsAPI.SaveCarAsync(bmw);
            if (!await RentalCarsAPI.CarAlreadyExist(mercedes1))
                await RentalCarsAPI.SaveCarAsync(mercedes1);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw1))
                await RentalCarsAPI.SaveCarAsync(bmw1);
            if (!await RentalCarsAPI.CarAlreadyExist(mercedes2))
                await RentalCarsAPI.SaveCarAsync(mercedes2);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw2))
                await RentalCarsAPI.SaveCarAsync(bmw2);
            if (!await RentalCarsAPI.CarAlreadyExist(mercedes3))
                await RentalCarsAPI.SaveCarAsync(mercedes3);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw3))
                await RentalCarsAPI.SaveCarAsync(bmw3);
            if (!await RentalCarsAPI.CarAlreadyExist(opel))
                await RentalCarsAPI.SaveCarAsync(opel);
            if (!await RentalCarsAPI.CarAlreadyExist(mercedes4))
                await RentalCarsAPI.SaveCarAsync(mercedes4);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw4))
                await RentalCarsAPI.SaveCarAsync(bmw4);
            if (!await RentalCarsAPI.CarAlreadyExist(audi))
                await RentalCarsAPI.SaveCarAsync(audi);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw5))
                await RentalCarsAPI.SaveCarAsync(bmw5);
            if (!await RentalCarsAPI.CarAlreadyExist(alfaRomeo))
                await RentalCarsAPI.SaveCarAsync(alfaRomeo);
            if (!await RentalCarsAPI.CarAlreadyExist(audi1))
                await RentalCarsAPI.SaveCarAsync(audi1);
            if (!await RentalCarsAPI.CarAlreadyExist(opel1))
                await RentalCarsAPI.SaveCarAsync(opel1);
            if (!await RentalCarsAPI.CarAlreadyExist(bmw6))
                await RentalCarsAPI.SaveCarAsync(bmw6);
            if (!await RentalCarsAPI.CarAlreadyExist(opel2))
                await RentalCarsAPI.SaveCarAsync(opel2);
            if (!await RentalCarsAPI.CarAlreadyExist(passat))
                await RentalCarsAPI.SaveCarAsync(passat);
            if (!await RentalCarsAPI.CarAlreadyExist(fiat))
                await RentalCarsAPI.SaveCarAsync(fiat);
            if (!await RentalCarsAPI.CarAlreadyExist(chevrolet))
                await RentalCarsAPI.SaveCarAsync(chevrolet);


            var cars = await RentalCarsAPI.GetCarsAsync();

            //await RentalCarsAPI.RentToPersonAsync(cars[0].CarId, Person.Create("TEST1", "TEST2", DateTime.Now, DateTime.Now.AddDays(1), "TEST3"));
        }
    }
}
