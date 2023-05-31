using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAcess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine(" Loading form a Monga database...");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine(" Saving to a Mongo database...");
        }
    }
}
