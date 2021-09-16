using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Domain
{
    public class Product
    {
        [ForeignKey("ProductTypeCode"), Required]
        public string ProductTypeCode { get; set; }

        public ProductType ProductType { get; set; }

        public string Id { get; set; }

        [NotMapped]
        public Dictionary<int, decimal> PricesByCurrency { get; set; }

        [Required]
        public int Currency { get; set; }

        public string Manager { get; set; }

        public string Market { get; set; }

        public bool IsTransferable { get; set; }

        public bool IsProductPurchasesSales { get; set; }

        public int? DecimalesTitulos { get; set; }

        public string GroupingClassCode { get; set; }

        public int OrderGroupingClass { get; set; }

        public decimal? ManagementCommission { get; set; }

        public Product()
        {
            PricesByCurrency = new Dictionary<int, decimal>();
        }

        public object Clone()
        {
            var productoClone = (Product)MemberwiseClone();
            productoClone.ProductType = ProductType.Clone();

            productoClone.PricesByCurrency = new Dictionary<int, decimal>();
            foreach (var divisaId in PricesByCurrency.Keys)
                productoClone.PricesByCurrency[divisaId] = PricesByCurrency[divisaId];

            return productoClone;
        }

        public override string ToString()
        {
            var strComision = ManagementCommission.HasValue ? $"(Comis: {ManagementCommission.Value})" : String.Empty;
            var strGestora = string.IsNullOrEmpty(Manager) ? $"({Manager})" : String.Empty;

            return $"{Id} ({ProductType.Code})({Currency}){strGestora}{strComision}";
        }
    }
}
