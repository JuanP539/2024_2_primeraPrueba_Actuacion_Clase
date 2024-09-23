using BusinessLogic;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;


namespace ServiceFactory
{
    public class DogServiceFactory
    {
        public void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DogLogic, DogLogic>();
            serviceCollection.AddSingleton<DogRepository, DogRepository>();
        }
    }
}
