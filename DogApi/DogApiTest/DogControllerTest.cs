using BusinessLogic;
using DogApi.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Models.In;
using Models.Out;
using Moq;

namespace DogApiTest
{
    [TestClass]
    public class DogControllerTest
    {
        private Dog _d;

        [TestInitialize]
        public void Setup() 
        {
            _d = new Dog() 
            {
                Breed = "Caucasian Shepherd Dog",
                Description = "The Caucasian Shepherd Dog is a large and powerful breed " +
                "of dog from the Caucasus Mountains region. These dogs are large in size," +
                " with a thick double coat to protect them from the cold. They have a regal" +
                " bearing, with a proud and confident demeanor. They are highly intelligent" +
                " and loyal, making them excellent guard dogs. They are courageous and alert" +
                ", with an instinct to protect their family and property. They are highly " +
                "trainable, but require firm and consistent training.",
                Hypoalergenic = false
            };
        }

        [TestMethod]
        public void CreateDogsOk() 
        {
            DogCreateModelOut expectedResult = new DogCreateModelOut() {Breed = _d.Breed, Description = _d.Description, Hypoalergenic = _d.Hypoalergenic };
            DogCreateModelIn dogCreateModel = new DogCreateModelIn() { Breed = _d.Breed, Description = _d.Description, Hypoalergenic = _d.Hypoalergenic };
            var mockDogLogic = new Mock<DogLogic>(MockBehavior.Strict);
            var dogController = new DogController(mockDogLogic.Object);

            var result = dogController.Create(dogCreateModel);
            var okResult = result as CreatedAtActionResult;
            var content = okResult.Value as DogCreateModelOut;

            mockDogLogic.VerifyAll();
            Assert.AreEqual(expectedResult, content);
        }

        [TestMethod]
        public void GetDogsOk() 
        {
            DogGetModelOut expectedResult = new DogGetModelOut() { Breed = _d.Breed, Description = _d.Description, Hypoalergenic = _d.Hypoalergenic };
            DogGetModelIn dogCreateModel = new DogGetModelIn() { Breed = _d.Breed};
            var mockDogLogic = new Mock<DogLogic>(MockBehavior.Strict);
            var dogController = new DogController(mockDogLogic.Object);

            var result = dogController.GetDogs(dogCreateModel);
            var okResult = result as OkObjectResult;
            var content = okResult.Value as DogGetModelOut;

            mockDogLogic.VerifyAll();
            Assert.AreEqual(expectedResult, content);
        }
    }
}
