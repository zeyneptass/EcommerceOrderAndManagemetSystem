using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;            
        }

        [HttpGet("getallProducts")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("addProduct")]
        public async Task<IActionResult> Add(Product product)
        {
            var result =  await _productService.AddAsync(product);
            if (result.Success)
            {   
                return Ok(result);                
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbycategoryid")]
        public async Task<IActionResult> GetAllByCategoryId(int categoryId)
        {
            var result = await _productService.GetAllByCategoryIdAsync(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyunitprice")]
        public async Task<IActionResult> GetByUnitPrice(decimal min,decimal max)
        {
            var result = await _productService.GetByUnitPriceAsync(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
<<<<<<< HEAD
=======
        [HttpGet("getProductsDetails")]
>>>>>>> 1f9d2f4 (CategoriesController class is created)
        public async Task<IActionResult> GetProductsDetails()
        {
            var result = await _productService.GetProductDetailsAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
