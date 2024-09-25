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
        [HttpDelete("id")]
        public IActionResult DeleteDogByIdDogs([FromQuery] string dogId)
        {
            Dog dog = _dogLogic.DeleteDogById(dogId);
            DogDeleteModelOut dogModelOut = new DogDeleteModelOut(dog);
            return CreatedAtAction(nameof(UpdateDog), dogModelOut); //returns 201
        }
        [HttpPut]
        public IActionResult UpdateDog([FromBody] DogUpdateModelIn dogUpdateModel)
        {
            Dog dog = _dogLogic.UpdateDogByBreed(dogUpdateModel.ToEntity());
            DogUpdateModelOut dogModelOut = new DogUpdateModelOut(dog);
            return Ok(dogModelOut); //returns 200
        }
    }
}
