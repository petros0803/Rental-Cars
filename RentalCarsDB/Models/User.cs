﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarsDB.Models
{
    [Table("Users")]
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        protected User()
        {

        }
        public static User Create(string username, string password)
        {
            return new User() { UserId = Guid.NewGuid(), Username = username, Password = password };
        }

    }
}
