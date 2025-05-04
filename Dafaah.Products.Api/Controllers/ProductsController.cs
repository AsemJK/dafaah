using Dafaah.Products.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dafaah.Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<List<ProductDto>> List()
        {
            return new List<ProductDto> { new ProductDto(Id: 1) };
        }
    }
}
