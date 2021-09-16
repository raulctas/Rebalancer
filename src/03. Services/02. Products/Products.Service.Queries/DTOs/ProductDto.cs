using Products.Domain;

namespace Catalog.Service.Queries.DTOs
{
    public class ProductDto
    {
        public string Id { get; set; }
        public ProductTypeDto ProductType { get; set; }
        public int Currency { get; set; }
    }
}
