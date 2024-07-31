using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Database");

            return new List<Product>()
            {
                new Product() { Name = "Taylor Swift Shirt", Price = 29.99m },
                new Product() { Name = "TS Record", Price = 25.99m },
                new Product() { Name = "TS Concert Tickets", Price = 459.99m },
                new Product() { Name = "TS Sunglasses, Price = 39.99m" },
                new Product() { Name = "TS Polarized Sunglasses, Price = 59.99m "}

            };

        }


        public void SaveData()
        {
            Console.WriteLine("Saving data to your Mongo Database");
        }
    }
}
