using BusinessLogic;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;

namespace DogApi.Controllers
{
    [ApiController]
    [Route("api/dogs")]
    public class DogController : ControllerBase
    {
        private readonly DogLogic _dogLogic;
        public DogController(DogLogic dogLogic) 
        {
            _dogLogic = dogLogic;
        }
        [HttpGet]
        public IActionResult GetDogs([FromQuery] DogGetModelIn dogGetModel)
        {
            Dog dog = _dogLogic.GetByBreed(dogGetModel.ToEntity());
            DogGetModelOut dogModelOut = new DogGetModelOut(dog);
            return CreatedAtAction(nameof(Create), dogModelOut); //returns 201
        }
        [HttpPost]
        public IActionResult Create([FromBody] DogCreateModelIn dogCreateModel)
        {
            Dog dog = _dogLogic.CreateDog(dogCreateModel.ToEntity());
            DogCreateModelOut dogModelOut = new DogCreateModelOut(dog);
            return Ok(dogModelOut); //returns 200
        }
    }
}
