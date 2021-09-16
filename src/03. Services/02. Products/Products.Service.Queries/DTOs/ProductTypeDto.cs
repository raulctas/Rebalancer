namespace Products.Domain
{
    public class ProductTypeDto
    {
        public string Code { get; set; }

        public int Order { get; set; }

        public ProductTypeDto Clone()
        {
            return (ProductTypeDto)MemberwiseClone();
        }
    }
}
