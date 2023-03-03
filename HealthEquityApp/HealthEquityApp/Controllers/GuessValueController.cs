using Microsoft.AspNetCore.Mvc;
using HealthEquityApp.Dal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthEquityApp.Controllers
{
    [Route("api/[controller]")]
    public class GuessValueController : ControllerBase
    {

        private readonly ICarService _carService;

        public GuessValueController(ICarService carService)
        {
            _carService = carService;
        }


        // POST api/values
        [HttpPost("{carId}/{guessValue}")]
        public async Task<IActionResult> Post([FromRoute]int carId, int guessValue)
        {
            var guessResult = await _carService.GuessPriceWithin5000RangeAsync(carId, guessValue);
            return new OkObjectResult(guessResult);
        }
    }
}

