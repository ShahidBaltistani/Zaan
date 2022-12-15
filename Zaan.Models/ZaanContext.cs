using Microsoft.EntityFrameworkCore;
using Zaan.Models.Model;

namespace Zaan.Models
{
    public class ZaanContext : DbContext
    {
        public ZaanContext(DbContextOptions<ZaanContext> options) :base(options)
        {

        }
        public DbSet <FoodCategory> FoodCategories { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Saler> Saler { get; set; }
        public DbSet <Role> Roles { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <Food> Foods { get; set; }
        public DbSet <Review> Reviews { get; set; }
        public DbSet <Image> Images { get; set; }
        public DbSet <DeliveryBoy> DeliveryBoys { get; set; }
    }
}