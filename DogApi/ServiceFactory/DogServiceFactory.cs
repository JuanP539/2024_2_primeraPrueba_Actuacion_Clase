using BusinessLogic;
using DataAccess;
using Microsoft.Extensions.DependencyInjection;


namespace ServiceFactory
{
    public static class DogServiceFactory
    {
        public static void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DogLogic, DogLogic>();
            serviceCollection.AddSingleton<DogRepository, DogRepository>();
        }
    }
}
