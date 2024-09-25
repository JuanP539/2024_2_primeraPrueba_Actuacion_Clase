using Domain;
using IDataAccess;
using IDataAccess.Exceptions;

namespace DataAccess
{
    public class DogRepository : IDogRepository
    {
        public Dog DeleteByBreed(string dog)
        {
            Dog ret = DataBase.Instance.DeleteDog(dog);
            if (ret == null) 
            {
                throw new DataNotFoundException();
            }
            return ret;
        }
        public Dog UpdateByBreed(Dog dog)
        {
            Dog ret = DataBase.Instance.UpdateDog(dog);
            if (ret == null)
            {
                throw new DataNotFoundException();
            }
            return ret;
        }
    }
}
