using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Database.");

            return new List<Product>()
            {
                new Product() { Name = "Beach Chair", Price = 10.99m},
                new Product() { Name = "Towel", Price = 6.99m},
                new Product() { Name = "3-Pack Towels", Price = 14.99m},
                new Product() { Name = "Sunscreen", Price = 8.99m},
                new Product() { Name = "Goggles", Price = 15.99m},
                new Product() { Name = "Rash Guard Short-Sleeve", Price = 13.99m},
                new Product() { Name = "Rash Guard Long-Sleeve", Price = 18.99m}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to your Mongo Database");
        }
    }
}
