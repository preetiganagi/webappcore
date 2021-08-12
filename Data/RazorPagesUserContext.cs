using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webappcore.Models;

namespace RazorPagesUser.Data
{
    public class RazorPagesUserContext : DbContext
    {
        public RazorPagesUserContext (DbContextOptions<RazorPagesUserContext> options)
            : base(options)
        {
        }

        public DbSet<webappcore.Models.User> User { get; set; }
        public DbSet<webappcore.Models.Address> Address { get; set; }
        public DbSet<webappcore.Models.UserAddress> UserAddress { get; set; }


    }
}
