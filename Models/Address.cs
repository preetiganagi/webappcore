using System;
using System.ComponentModel.DataAnnotations;

namespace webappcore.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Pincode { get; set; }
    
    }
}
