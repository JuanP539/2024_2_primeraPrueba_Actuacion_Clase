using Domain;
using IBusinessLogic;
using IBusinessLogic.Exceptions;
using IDataAccess;
using IDataAccess.Exceptions;

namespace BusinessLogic
{
    public class DogLogic : IDogLogic
    {
        private IDogRepository _dogRepo;
        public DogLogic(IDogRepository dogRepo) 
        {
            _dogRepo = dogRepo;
        }

        public Dog GetByBreed(Dog dog)
        {
            try
            {
                return _dogRepo.GetByBreed(dog.Breed);
            }
            catch (DataNotFoundException)
            {
                throw new DogNotFoundException();
            }
        }

        public Dog CreateDog(Dog newDog)
        {
            try
            {
                return _dogRepo.Create(newDog);
            }
            catch (DataNotFoundException)
            {
                throw new AlreadyExistingDogException();
            }
        }
    }
}
