namespace Catalog.API.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
    }
}
