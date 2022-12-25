using Entities;

namespace Repository
{
    public interface ICarRepository
    {
        Task<Car> addCar(Car car);
        Task deleteCar(Car car);
        Task<IEnumerable<Car>> getAllCars();
        Task<Car> getCarByID(int id);
        Task updateCar(Car car);
    }
}