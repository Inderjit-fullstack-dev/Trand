using Catalog.API.Application.ProductService.Queries;
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

    }
}
