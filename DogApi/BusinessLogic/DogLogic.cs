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

        public Dog DeleteDogById(string dog)
        {
            try
            {
                return _dogRepo.DeleteByBreed(dog);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public Dog UpdateDogByBreed(Dog newDog)
        {
            try
            {
                return _dogRepo.UpdateByBreed(newDog);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
