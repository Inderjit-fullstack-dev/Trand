namespace Catalog.API.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; } 
        public string ProductSlug { get; set; } 
        public string Description { get; set; }  
        public string ShortDescription { get; set; }  
        public decimal Price { get; set; }
        public Brand Brand { get; set; }
        public List<Category> Categories { get; set; }
        public List<string> ImagePaths { get; set; } 
    }
}
