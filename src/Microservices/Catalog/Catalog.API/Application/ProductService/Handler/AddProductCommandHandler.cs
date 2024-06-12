using Catalog.API.Application.ProductService.Commands;
using Catalog.API.Domain.Entities;
using Catalog.API.Infrastructure.Helpers;
using Marten;
using MediatR;

namespace Catalog.API.Application.ProductService.Handler
{
    public class AddProductCommandHandler(IDocumentSession documentSession) : IRequestHandler<AddProductCommand, long>
    {
        private readonly IDocumentSession _documentSession = documentSession;

        public async Task<long> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                ProductName = request.ProductName,
                Description = request.Description,
                ShortDescription = request.ShortDescription,
                Price = request.Price,
                Brand = request.Brand,
                Categories = request.Categories,
                ImagePaths = request.ImagePaths
            };

            _documentSession.Store<Product>(product);
            await _documentSession.SaveChangesAsync(cancellationToken);

            return product.Id; 
        }
    }
}
