namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // this keep the user in the do while loop until they type in the right input
            string userDatabase;
            bool inputError;
            do 
            {
                Console.Clear();
                inputError = true;

                Console.WriteLine("Which database would you like to use: List, SQL or Mongo?");

                userDatabase = Console.ReadLine();

                if (userDatabase != "sql" && userDatabase != "mongo" && userDatabase != "list")
                {
                    inputError = false;
                    Console.WriteLine("Input not accepted, please enter a valid database name");
                    Thread.Sleep(2000);
                }
            } while (!inputError);

         

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(userDatabase);
            var products = dataAccess.LoadData();
            dataAccess.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
