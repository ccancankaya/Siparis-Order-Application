using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipraişUygulaması
{
    class OrderContext:DbContext
    {
        //public OrderContext():base("OrderSystem")
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrderContext);
        //}



        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopAccout> ShopAccouts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
