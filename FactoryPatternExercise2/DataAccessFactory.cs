using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                case "sql":
                    return new SQLDataAccess();

            }

            Console.WriteLine("Sorry we don't have that database, making database SQL by default");
            return new SQLDataAccess();

        } 
    }
}
