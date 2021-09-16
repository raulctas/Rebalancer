using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Products.Persistence.Database.Configuration
{
    public class ProductTypeConfiguration
    {
        public ProductTypeConfiguration(EntityTypeBuilder<ProductType> entityBuilder, List<Product> products)
        {
            entityBuilder.HasKey(x => x.Code);

            entityBuilder
                .HasMany(eb => eb.Products)
                .WithOne(eb => eb.ProductType)
                .HasForeignKey(eb => eb.ProductTypeCode);

            var accion = Constants.ProductTypes.Accion;

            foreach (var p in products.Where(p => p.ProductType.Code == Constants.ProductTypes.Accion.Code))
                accion.Products.Add(p);

            entityBuilder.HasData(new List<ProductType>()
            {
                accion,
                //Constants.ProductTypes.Depositos,
                //Constants.ProductTypes.Etf,
                //Constants.ProductTypes.Fondo,
                //Constants.ProductTypes.Liquidez,
                //Constants.ProductTypes.Otros,
                //Constants.ProductTypes.PlanesPensiones,
                //Constants.ProductTypes.RentaFija,
                //Constants.ProductTypes.Seguros,
                //Constants.ProductTypes.Sicav
            });
        }
    }
}
