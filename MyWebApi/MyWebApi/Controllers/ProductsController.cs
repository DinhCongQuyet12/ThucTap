using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Services;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IHangHoaRepository _hangHoaRepository;

        public ProductsController(IHangHoaRepository hangHoaRepository)
        {
            _hangHoaRepository = hangHoaRepository;
        }
        [HttpGet]
        public  IActionResult GetAllProducts(string search)
        { 
            try
            {
                var result = _hangHoaRepository.GetAll(search);
                return Ok(result);
            }
            catch
            {
                return BadRequest("We can't get the product.");
            }
        }
    }
}
