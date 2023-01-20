using BlazorECommerce.Shared;
using ECommerceApplication.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using ECommerceApplication.Shared;

namespace BlazorECommerce.Server.Controllers
{
    // all api urls begin from https://localhost:7166/api/product/routename
    [Route("api/[controller]")]
    [ApiController]


    public class ProductController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        public ProductController(DataContext Dbcontext)
        {
            _dbcontext = Dbcontext;
        }


        [HttpGet("getAllItems")]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await _dbcontext.Products.ToListAsync();

            return Ok(products);
        }

    }

}
