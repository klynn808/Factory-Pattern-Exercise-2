using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Database.");

            return new List<Product>()
            {
                new Product() { Name = "One Online Yoga Class", Price = 9.99m },
                new Product() { Name = "Five-Class Pack Online", Price = 39.99m },
                new Product() { Name = "Unlimited Monthly Membership Online", Price = 21.99m },
                new Product() { Name = "Arm Balance MasterClass Online", Price = 19.99m },
                new Product() { Name = "Creative Sequencing Workshop Online", Price = 25.99m },
                new Product() { Name = "Creative Sequence Flow Bundle", Price = 39.99m },
                new Product() { Name = "Creative Sequencing Workshop Flow Bundle", Price = 59.99m }
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to your Mongo Database");
        }
    }
}
