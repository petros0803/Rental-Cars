using RentalCarsDB.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB.Models
{
    [Table("Cars")]
    public class Car
    {
        protected Car()
        {

        }

        public Guid CarId { get; set; }
        public bool Rented { get; set; }
        public string CarModel { get; set; }
        public string CarPlate { get; set; }
        public DateTime ManufactoreDate { get; set; }
        public FuelType FuelType { get; set; }
        public double EngineSize { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public virtual Person Person { get; set; }

        public static Car Create(string carModel, string carPlate, double engineSize, DateTime firstRegistrationDate, FuelType fuelType, DateTime manufactoreDate)
        {
            return new Car()
            {
                CarId = Guid.NewGuid(),
                CarModel = carModel,
                CarPlate = carPlate,
                EngineSize = engineSize,
                FirstRegistrationDate = firstRegistrationDate,
                FuelType = fuelType,
                ManufactoreDate = manufactoreDate,
                Person = null,
                Rented = false
            };
        }
    }
}
