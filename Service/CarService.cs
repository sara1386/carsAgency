using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CarService : ICarService
    {
        private ICarRepository carRepository;
        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public async Task<Car> getCarByID(int id)
        {
            return await carRepository.getCarByID(id);
        }

        public async Task<IEnumerable<Car>> getAllCars()
        {
            return await carRepository.getAllCars();
        }
        public async Task<Car> addCar(Car car)
        {
            return await carRepository.addCar(car);
        }

        public async Task updateCar(Car car)
        {
            await carRepository.updateCar(car);
        }
        public async Task deleteCar(Car car)
        {
            await carRepository.deleteCar(car);
        }


    }
}
