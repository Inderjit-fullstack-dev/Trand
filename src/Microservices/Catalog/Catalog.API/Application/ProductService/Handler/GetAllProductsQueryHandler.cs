using Catalog.API.Application.ProductService.Queries;
using Catalog.API.Domain.Entities;
using MediatR;

namespace Catalog.API.Application.ProductService.Handler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            List<Product> products = [];
            return products;
        }
    }
}
