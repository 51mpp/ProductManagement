using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.DTO;
using ProductManagementAPI.Interfaces;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockChangeController : ControllerBase
    {
        private readonly IStockChangeRepository _iStockChangeRepository;
        public StockChangeController(IStockChangeRepository iStockChangeRepository)
        {
            _iStockChangeRepository = iStockChangeRepository;
        }




        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ICollection<StockChange>))]
        public IActionResult GetAllStockChanges()
        {
            var stockChanges = _iStockChangeRepository.GetAll();
            return Ok(stockChanges);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddStockChange([FromBody] StockChangeDTO stockChange)
        {
            try
            {
                _iStockChangeRepository.AddStockChange(stockChange);
                return Ok(new { success = true });
            }
            catch (InvalidOperationException ex)
            {
                if(ex.Message == "Product not found.")
                {
                    return NotFound(new { success = false, error = ex.Message });
                }
                else if (ex.Message == "Stock is not enough to withdraw.")
                {
                    return BadRequest(new { success = false, error = ex.Message });
                }
                else
                {
                    return BadRequest(new { success = false, error = ex.Message });
                }
            }
            catch (Exception ex)
            {
                // ข้อผิดพลาดทั่วไป
                Console.WriteLine(ex.InnerException?.Message);

                return StatusCode(500, new { success = false, error = ex.Message });
            }
        }

    }

}
