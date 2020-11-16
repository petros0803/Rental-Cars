using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB.Models
{
    [Table("Histories")]
    public class History
    {
        protected History()
        {

        }
        [Key]
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNP { get; set; }
        public int Counter { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public static History Create(string firstName, string lastName, string cnp, DateTime fromDate, DateTime toDate)
        {
            return new History()
            {
                PersonId = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                CNP = cnp,
                FromDate = fromDate,
                ToDate = toDate,
                Counter = 1
            };
        }
    }
}
