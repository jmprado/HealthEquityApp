using HealthEquityApp.Dal;
using Microsoft.EntityFrameworkCore;

namespace HealthEquityApp
{
    public static class Startup
    {        
        // Register dependency injection services
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
        }

        // Add test data to in memory database
        public static async void InitInMemoryDatabase(IServiceProvider provider)
        {
            var carService = provider.GetService<ICarService>();

            if (carService != null)
                await carService.InitTestDataAsync();
            else
                throw new ArgumentNullException("Car service cannot be null, please register the car service before init in memory database");
        }
    }
}
