using Microsoft.EntityFrameworkCore;

namespace _4_CodeFirst_NetCoreEF.Models
{
    public class MyShopAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false) //ayarlamalar yapılmadıysa
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyShopApp;Trusted_Connection=True");
            }
        }
    }
}
