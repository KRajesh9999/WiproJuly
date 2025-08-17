using Microsoft.EntityFrameworkCore;
using CmsProject_Core_.Models;   // make sure this namespace contains Menu, Vendor, Order

namespace CmsProject_Core_.Models
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> opts) : base(opts) { }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Wallet> Wallets => Set<Wallet>();

        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<Vendor> Vendors => Set<Vendor>();
        public DbSet<Order> Orders => Set<Order>();   // optional, but needed for /Orders
    }
}
