using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tema6.Interfaces;
using Tema6.Entities;


namespace Tema6
{
    class Program
    {
        private static IRepository<ModelCar> carRepository = new EntityFrameworkRepository<ModelCar>();

        private static IRepository<ModelCar> carRepositoryMOngoDB = new MongoDbRepository<ModelCar>();

        static void Main(string[] args)
        {
            AddCarModel();
            ReadModels();
            ChangeModel();
            DeleteModel();
        }
        private static void AddCarModel()
        {
            carRepository.Insert(
                 new ModelCar
                 {
                     ModelName = "A4",
                     Price = 10000,
                     Year = 2015,
                     IdBrand = 1
                 });
        }

        private static void ReadModels()
        {
            var cars = carRepository.GetByAll();

            Console.WriteLine("Models in the database:");

            foreach (var car in cars)
            {
                Console.WriteLine(car.ModelName);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        private static void ChangeModel()
        {
            var car = carRepository.GetByAll().Where(s => s.ModelName == "A4").Single();
            car.ModelName = "X6";
            carRepository.Update(car);
        }

        private static void DeleteModel()
        {

            var car = carRepository.GetByAll().Where(s => s.ModelName == "A4").Single();
            carRepository.Delete(car);

        }
    }
}
