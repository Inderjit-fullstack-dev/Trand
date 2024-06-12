using Catalog.API.Application.ProductService.Queries;
using Catalog.API.Domain.Entities;
using Marten;
using MediatR;

namespace Catalog.API.Application.ProductService.Handler
{
    public class GetAllProductsQueryHandler(IDocumentSession documentSession) : IRequestHandler<GetAllProductsQuery, IReadOnlyList<Product>>
    {
        private readonly IDocumentSession _documentSession = documentSession;

        public async Task<IReadOnlyList<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _documentSession.Query<Product>().ToListAsync(cancellationToken); 
        }
    }
}
