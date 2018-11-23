using System.Data.Entity;

namespace Mobileshop.Models
{
    public class MobileContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }
}