using Microsoft.EntityFrameworkCore;
using Products.Domain;
using Products.Persistence.Database.Configuration;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Database schema
            builder.HasDefaultSchema("Products");

            // Model Contraints
            ModelConfig(builder);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            var productConfiguration = new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductTypeConfiguration(modelBuilder.Entity<ProductType>(), productConfiguration.Products);
        }
    }
}
