using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAcess GetDataBase(string dbType)
        {
            switch(dbType.ToLower())
           {
                case "List":
                    return new ListDataAccess();
                case "sql":
                case "mysql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
        

        
    }
}
