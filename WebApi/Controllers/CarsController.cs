using Microsoft.AspNetCore.Mvc;
using Patterns.Creational.FactoryMethod.CarMaker;
using Patterns.Creational.FactoryMethod.CarMaker.Factories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private CarFactory Factory { get; set; }


        public CarsController(CarFactory factory)
        {
            Factory = factory;
        }


        [HttpGet]
        public Car Get()
        {
            // Compare...
            //var car = new CombustionEngineCar();

            // ...to...
            var car = Factory.Assemble();

            // Which is more versatile? Why?


            // ...

            return car;
        }
    }
}
