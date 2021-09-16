using System.Collections.Generic;

namespace Products.Domain
{
    public class ProductType
    {
        public string Code { get; set; }

        public int Order { get; set; }

        public virtual IList<Product> Products { get; set; }

        public ProductType()
        {
            Products = new List<Product>();
        }

        public ProductType Clone()
        {
            return (ProductType)MemberwiseClone();
        }
    }
}
