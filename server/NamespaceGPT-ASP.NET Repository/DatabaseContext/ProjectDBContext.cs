using Microsoft.EntityFrameworkCore;
using NamespaceGPT.Data.Models;

namespace NamespaceGPT_ASP.NET_Repository.DatabaseContext
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }

        public DbSet<User> AppUser { get; set; } = null!;
        public DbSet<AdRecommendation> AdRecommendation { get; set; } = null!;
        public DbSet<BackInStockAlert> BackInStockAlerts { get; set; } = null!;
        public DbSet<FavouriteProduct> FavouriteProduct { get; set; } = null!;
        public DbSet<Listing> Listing { get; set; } = null!;
        public DbSet<Marketplace> Marketplace { get; set; } = null!;
        public DbSet<NewProductAlert> NewProductAlerts { get; set; } = null!;
        public DbSet<PriceDropAlert> PriceDropAlerts { get; set; } = null!;
        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<Review> Review { get; set; } = null!;
        public DbSet<UserActivity> UserActivity { get; set; } = null!;
        public DbSet<Sale> Sale { get; set; } = default!;
    }
}
