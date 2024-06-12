using Catalog.API.Application.ProductService.Commands;
using Catalog.API.Application.ProductService.Queries;
using Catalog.API.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {

            try
            {
                var result = await _mediator.Send(new GetAllProductsQuery());
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product request)
        {
            try
            {
                var result = await _mediator.Send(
                    new AddProductCommand 
                    {
                        ProductName = request.ProductName,
                        Description = request.Description,
                        ShortDescription = request.ShortDescription,
                        Price = request.Price,
                        Brand = request.Brand,
                        Categories = request.Categories,
                        ImagePaths = request.ImagePaths
                    }
                );
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
