using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB.Models
{
    [Table("People")]
    public class Person
    {
        protected Person()
        {

        }
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNP { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual Car Car { get; set; }

        public static Person Create(string cnp, string firstName, DateTime fromDate, DateTime toDate, string lastName)
        {
            return new Person()
            {
                CNP = cnp,
                FirstName = firstName,
                FromDate = fromDate,
                ToDate = toDate,
                LastName = lastName,
                PersonId = Guid.NewGuid()
            };
        }
    }
}
