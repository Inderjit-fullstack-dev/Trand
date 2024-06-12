using Catalog.API.Domain.Entities;
using MediatR;

namespace Catalog.API.Application.ProductService.Commands
{
    public class AddProductCommand : IRequest<long>
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public Brand Brand { get; set; }
        public List<Category> Categories { get; set; }
        public List<string> ImagePaths { get; set; }
    }
}
