using HealthEquityApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthEquityApp.Dal
{
    public interface ICarService
    {
        Task<Car> GetAsync(int id);
        Task<IEnumerable<Car>> GetAllAsync();
        Task<Car> CreateAsync(Car car);
        Task<Car> UpdateAsync(Car car);
        Task DeleteAsync(int id);
        Task InitTestDataAsync();
        Task<bool> GuessPriceWithin5000RangeAsync(int carId, int guessValue);
    }
}