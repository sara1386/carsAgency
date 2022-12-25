using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class CarRepository : ICarRepository
    {
        private CompanyAgentContext dbContext;
        public CarRepository(CompanyAgentContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Car> getCarByID(int id)
        {
            return await dbContext.Cars.FindAsync(id);
        }

        public async Task<IEnumerable<Car>> getAllCars()
        {
            return await dbContext.Cars.ToListAsync();

        }
        public async Task<Car> addCar(Car car)
        {
            await dbContext.Cars.AddAsync(car);
            await dbContext.SaveChangesAsync();
            return car;

        }

        public async Task updateCar(Car car)
        {
            dbContext.Cars.Update(car);
            await dbContext.SaveChangesAsync();

        }
        public async Task deleteCar(Car car)
        {
            dbContext.Cars.Remove(car);
            await dbContext.SaveChangesAsync();
        }

    }
}
