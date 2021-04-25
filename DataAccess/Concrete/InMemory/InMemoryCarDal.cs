using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2014, DailyPrice = 125000, Description = "TOYOTA COROLLA"},
                new Car(){CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 2019, DailyPrice = 195000, Description = "TOYOTA AURİS"},
                new Car(){CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2011, DailyPrice = 95000, Description = "FORD FİESTA"},
                new Car(){CarId = 4, BrandId = 2, ColorId = 2, ModelYear = 2014, DailyPrice = 215000, Description = "FORD FOCUS"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);

            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
