using System;
namespace webappcore.Models
{
    public class UserAddress
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int Status { get; set; }
        public string username { get; set; }

    }
}
