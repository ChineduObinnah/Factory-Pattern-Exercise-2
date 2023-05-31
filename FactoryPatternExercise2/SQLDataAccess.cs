using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAcess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading from a SQL database...");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving a SQL dabtabase...");
        }
    }
}
