using Catalog.API.Domain.Entities;
using MediatR;

namespace Catalog.API.Application.ProductService.Queries
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
    }
}
