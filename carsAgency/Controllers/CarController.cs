using Microsoft.AspNetCore.Mvc;
using Entities;
using Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace carsAgency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: api/<CarController>
        [HttpGet]
        public Task<IEnumerable<Car>> GetAll()
        {
            return carService.getAllCars();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public Task<Car> Get(int id)
        {
            return carService.getCarByID(id);
        }

        // POST api/<CarController>
        [HttpPost]
        public Task<Car> Post([FromBody] Car car)
        {
            return carService.addCar(car);
            
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody] Car car)
        {
            return carService.updateCar(car);

        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Car car)
        {
            await carService.deleteCar(car);
            return Ok();

        }
    }
}
