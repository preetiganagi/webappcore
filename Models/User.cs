using System;
using System.ComponentModel.DataAnnotations;

namespace webappcore.Models
{
    public class User
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }

    }
}
