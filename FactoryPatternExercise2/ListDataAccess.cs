using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAcess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine(" Loading from a list");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("saving data to a list db...");
        }
    }
}
       