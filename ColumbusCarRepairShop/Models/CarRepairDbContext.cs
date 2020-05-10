using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColumbusCarRepairShop.Models
{
    public class CarRepairDbContext : DbContext
    {
        public CarRepairDbContext(DbContextOptions<CarRepairDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
